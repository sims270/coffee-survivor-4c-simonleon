using UnityEngine;
using UnityEngine.UI;

public class CoffeeManager : MonoBehaviour
{
    public static CoffeeManager Instance;
    public GameOverManager manager;
    
    [SerializeField] private GameObject coffeeSlider;
    [SerializeField] private float drainRate = 5f;
    private float coffeeLevel = 100f;
    
    void Awake()
    {
        Instance = this;
    }
    
    void Update()
    {
        coffeeLevel -= drainRate * Time.deltaTime;
        //Change heigjt of total go  based on coffee level
        coffeeSlider.GetComponent<RectTransform>().sizeDelta = new Vector2(coffeeSlider.GetComponent<RectTransform>().sizeDelta.x, coffeeLevel);
        
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