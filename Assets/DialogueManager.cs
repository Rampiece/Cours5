using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] private Dialogue dialogue;
    [SerializeField] private TextMeshProUGUI questionTextComponent;
    [SerializeField] private TextMeshProUGUI answerTextComponent;
    
    // Start is called before the first frame update
    void Start()
    {
        questionTextComponent.text = dialogue.Question;
        answerTextComponent.text = dialogue.Answer;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
