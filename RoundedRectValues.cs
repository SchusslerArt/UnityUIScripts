using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class RoundedRectValues : MonoBehaviour
{
    [MenuItem("CONTEXT/RectTransform/Clean Up Values")]
    static void CleanUpValues(MenuCommand command)
    {
        RectTransform selectedTransform = (RectTransform)command.context;

        Undo.RecordObject(selectedTransform, "Clean Up Values");

        // Round the Size Delta values to the nearest integer
        selectedTransform.sizeDelta = new Vector2(Mathf.RoundToInt(selectedTransform.sizeDelta.x), Mathf.RoundToInt(selectedTransform.sizeDelta.y));

        // Round the Local Position values to the nearest integer
        selectedTransform.localPosition = new Vector3(Mathf.RoundToInt(selectedTransform.localPosition.x), Mathf.RoundToInt(selectedTransform.localPosition.y), selectedTransform.localPosition.z);

        // Round the Anchored Position values to the nearest integer
        selectedTransform.anchoredPosition = new Vector2(Mathf.RoundToInt(selectedTransform.anchoredPosition.x), Mathf.RoundToInt(selectedTransform.anchoredPosition.y));
    }
}