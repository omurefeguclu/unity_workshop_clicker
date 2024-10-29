using TMPro;
using UnityEngine;

public class ClickerGame : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public Camera mainCamera;
    
    
    public Color[] colors;
    
    private int _score = 0;
    private int _currentColorIndex;
    
    public void ButtonClicked()
    {
        Debug.Log("Button clicked!");
        
        //Increment score
        _score++;

        _currentColorIndex++;
        if(_currentColorIndex >= colors.Length)
        {
            _currentColorIndex = 0;
        }
        
        //Change camera background color
        mainCamera.backgroundColor = colors[_currentColorIndex];
        
        //Update score text
        scoreText.text = "Score: " + _score;
    }
}
