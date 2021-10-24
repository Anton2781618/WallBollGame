using UnityEngine;


public class GameController : MonoBehaviour
{
    private bool GameStart = false;

    private UiContainerObjects uiContainerObjects;
    private StartingSettingsModel startingSettingsModel;

    private CameraController cameraController;
    private ParallaxController parallaxController;

    private BollController bollController;
    private WallController wallController;

    private TimeController timeController;

    private void Start()
    {
        uiContainerObjects = FindObjectOfType<UiContainerObjects>();
        startingSettingsModel = FindObjectOfType<StartingSettingsModel>();

        cameraController = FindObjectOfType<CameraController>();
        parallaxController = FindObjectOfType<ParallaxController>();

        bollController = FindObjectOfType<BollController>();
        wallController = FindObjectOfType<WallController>();

        timeController = FindObjectOfType<TimeController>();

        timeController.SpeedUpEvent += startingSettingsModel.VerticalSpeedUp;
        CollisionCheker.CollisionEvent += End_Game;
    }
    private void Update()
    {
        if(GameStart)
        {            
            uiContainerObjects.TimeText.text = "Время игры: " + timeController.Timer();
            timeController.Culdown_For_Vertical_Speed();

            cameraController.Movemant_Camera(startingSettingsModel.SpeedCamera);
            parallaxController.Movement_Parallax(startingSettingsModel.SpeedParalax);
            bollController.Movement_Ball(startingSettingsModel.VerticalSpeed);
            wallController.Culdown_For_Change_Position();
        }
    }

    ///<summary>
    /// применить сложность
    ///<summary>
    public void ApplyComplexity(int value)
    {        
        startingSettingsModel.SpeedCamera = value + 6;
        startingSettingsModel.SpeedParalax = value + 1;
    }

    ///<summary>
    /// начать игру
    ///<summary>
    public void StartGame()
    {
        GameStart = true;
        
    }

    ///<summary>
    /// конец игры
    ///<summary>
    public void End_Game()
    {
        GameStart = false;

        bollController.DestroyBall();
        wallController.Reposition_Wals();

        parallaxController.Find_Paralax_Parent().gameObject.SetActive(false);
        uiContainerObjects.MyCanvas.transform.Find("TimeGame").gameObject.SetActive(false);

        startingSettingsModel.Attempt ++;

        uiContainerObjects.EndMenuTimeText.text = "Время игры " + timeController.Timer() + " сек";
        uiContainerObjects.EndMenuAttemptText.text = "Папытка № " + startingSettingsModel.Attempt;
        
        uiContainerObjects.MyCanvas.transform.Find("EndGameMenu").gameObject.SetActive(true);
        Restart_Game();
    }

    ///<summary>
    /// рестарт игры
    ///<summary>
    private void Restart_Game()
    {
        startingSettingsModel.SpeedCamera = 5;
        startingSettingsModel.SpeedParalax = 1;
        startingSettingsModel.VerticalSpeed = 1;
       

        timeController.Reset_Time();
    }
}
