using System;
using UnityEngine;

[CreateAssetMenu(fileName = "NewSauce", menuName = "Scriptable Objects/New Sauce")]
public class Sauces : ScriptableObject
{
    public string sauceName;
    [SerializeField] private string sauceID;
    public Sprite sauceIcon;

    private void OnValidate()
    {
        if (string.IsNullOrEmpty(sauceID))
        {
            sauceID = sauceName + Guid.NewGuid().ToString();
        }
    }
}
