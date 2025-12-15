using UnityEngine;
using UnityEngine.UI;

public class CoffeeManager : MonoBehaviour
{
    public static CoffeeManager Instance;
    public GameOverManager manager;
    
    [SerializeField] private GameObject coffeeSlider;
    [SerializeField] private float drainRate = 5f;
    private float coffeeLevel = 100f;
    private float originalHeight;
    
    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        // Store the original height of the coffee slider for reference
        originalHeight = coffeeSlider.GetComponent<RectTransform>().sizeDelta.y;
    }
    
    void Update()
    {
        coffeeLevel -= drainRate * Time.deltaTime;
        // Change height of total go based on coffee level, using the original height as reference
        coffeeSlider.GetComponent<RectTransform>().sizeDelta = new Vector2(
            coffeeSlider.GetComponent<RectTransform>().sizeDelta.x, 
            originalHeight * (coffeeLevel / 100f)
        );

        if (coffeeLevel <= 0)
        {
            manager.TriggerGameOver();
            Debug.Log("TODO: Hier macht PERSON 2 weiter - Game Over auslösen");
        }
    }
    
    public void RefillCoffee()
    {
        coffeeLevel = 100f;
        Debug.Log("Kaffee aufgefüllt!");
    }
}