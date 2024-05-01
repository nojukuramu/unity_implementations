using UnityEngine;
using System.IO;

public class TextFileReader : MonoBehaviour
{
    // Name of the text file you want to read
    public string fileName = "macro.txt";

    // Function to read the text file line by line
    public string ReadTextFile(float lineNumberToRead)
    {
        string filePath = Path.Combine(Application.streamingAssetsPath, fileName);
        if (File.Exists(filePath)) {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    for (int i = 0; i < lineNumberToRead; i++) {
                        if (reader.ReadLine() == null) {
                            Debug.LogWarning("Line number exceeds total number of lines in the file.");
                            return "<MaxLineReached>";
                        }
                    }
                    // Read and return the desired line
                    string line = reader.ReadLine();
                    return line;
                }
            }
            catch (System.Exception e)
            {
                Debug.LogError("Error reading the text file: " + e.Message);
                return "<Error>";
            }
        }
        else
        {
            Debug.LogError("Text file not found: " + filePath);
                return "<Error>" ;
        }
    }
}
