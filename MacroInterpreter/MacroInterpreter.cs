using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MacroInterpreter : MonoBehaviour
{   
    public Text text; //sample usage
    void Start()
    {
        StartCoroutine(InterpreterLogic()); //sample usage: Activates the Interpreter at first frame.
    }

    void Update()
    {

    }

    IEnumerator InterpreterLogic(){
        string lineFromText = null;
        float lineIndex = 0;

        while (lineFromText != "<MaxLineReached>" || lineFromText != "<Error>") {
            lineFromText = GetComponent<TextFileReader>().ReadTextFile(lineIndex);

            //Your Function Here
            text.text = lineFromText; //sample usage

            //increment line index then yield.
            lineIndex += 1;
            yield return new WaitForSeconds(1); //yield then wait 

            //condition to break
            if (lineFromText == "<MaxLineReached>" || lineFromText == "<Error>"){
                lineIndex = 0;
                break;
            }
        }

        
    }
}
