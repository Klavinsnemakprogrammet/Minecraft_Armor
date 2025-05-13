using UnityEngine;
using UnityEngine.UI;

public class AgeCalcScript : MonoBehaviour
{
    
    public InputField nameInput;
    public InputField birthYearInput; 
    public Button getTextButton; 
    public Text resultText;
    void Start()
    {

        getTextButton.onClick.AddListener(CalculateAndDisplayAge);
    }

    void CalculateAndDisplayAge()
    {
 
        string playerName = nameInput.text;

        
        if (int.TryParse(birthYearInput.text, out int birthYear))
        {
            
            int currentYear = System.DateTime.Now.Year;
            int age = currentYear - birthYear;

            
            if (age >= 0 && age < 150)
            {
                
                resultText.text = "Spēlētājs " + playerName + " ir " + age + " gadus vecs";
            }
            else
            {
                
                resultText.text = "Ievadi derīgu dzimšanas gadu";
            }
        }
        else
        {
            
            resultText.text = "Ievadi derīgu dzimšanas gadu";
        }
    }
}