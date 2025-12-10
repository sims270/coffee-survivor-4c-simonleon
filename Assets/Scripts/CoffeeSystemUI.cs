using UnityEngine;
using UnityEngine.UI;

public class CoffeeLevelUI : MonoBehaviour
{
    public Image fillImage;

    public Color fullColor = new Color(0.4f, 0.2f, 0.05f); // Braun
    public Color emptyColor = Color.red;

    // value = 1
    public void SetCoffeeLevel(float value)
    {
        value = Mathf.Clamp01(value);

        fillImage.fillAmount = value;

        // Farbverlauf
        fillImage.color = Color.Lerp(emptyColor, fullColor, value);
    }
}
