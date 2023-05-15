/*
SliderValueHandler.cs
Author: CireWire
Description:
    Monitor changes to a slider's value and performs actions based on the current value.

*/

using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Monitor changes to a slider's value and performs actions based on the current value.
/// </summary>

public class SliderValueHandler : MonoBehaviour
{
    public Slider slider;

    private void Start()
    {
        // Add a listener to the slider's value change event
        slider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    /// <summary>
    /// Callback method when the slider's value changes.
    /// </summary>
    /// <param name="value">The slider's current value.</param>

    private void OnSliderValueChanged(float value)
    {
        // Do something with the slider's value
        Debug.Log("Slider value changed to: " + value);

        // Example actions:
        if (value < 0.25f)
        {
            // Do something if the value is less than 0.25
        }
        else if (value < 0.5f)
        {
            // Do something if the value is between 0.25 and 0.5
        }
        else 
        {
            // Do something if the value is greater than or equal to 0.5
        }
    }
}