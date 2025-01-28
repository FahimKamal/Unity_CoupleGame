using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionGenerator : MonoBehaviour
{
    public List<Question> questions = new List<Question>();
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            var question = new Question($"What is the No. {i} question?", 
                "OptionA", "OptionB", "OptionC", "OptionD");
            questions.Add(question);
        }
    }
    
}

[Serializable]
public class Question
{
    public string QuestionBody;
    public string OptionA;
    public string OptionB;
    public string OptionC;
    public string OptionD;

    public string GetQuestionBody()
    {
        return QuestionBody;
    }

    public (string OptionA, string OptionB, string OptionC, string OptionD) GetOptions()
    {
        return (OptionA, OptionB, OptionC, OptionD);
    }

    public Question(string questionBody, string optionA, string optionB, string optionC, string optionD)
    {
        QuestionBody = questionBody;
        OptionA = optionA;
        OptionB = optionB;
        OptionC = optionC;
        OptionD = optionD;
    }
}
