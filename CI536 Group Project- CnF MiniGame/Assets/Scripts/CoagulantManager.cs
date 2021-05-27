using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoagulantManager : MonoBehaviour
{
    public GameOverScreen GameOverScreen;
    public static CoagulantManager instance;
    public Text coagulantText;
    int coagulant = 25;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        coagulantText.text = "Coagulant Left: " + coagulant.ToString();
    }

    void Update()
    {
        if (coagulant < 0) 
        { 
            coagulant = 0;
            coagulantText.text = "Coagulant Left: " + coagulant.ToString();
        }

       if (coagulant == 0)
        {
            GameOverScreen.Setup();
        }

    }

    public void RemoveCoagulant()
    {
        coagulant -= 1;
        coagulantText.text = "Coagulant Left: " + coagulant.ToString();
    }
}