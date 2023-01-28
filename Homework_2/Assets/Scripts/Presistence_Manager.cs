using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Presistence_Manager : MonoBehaviour
{   [SerializeField] PlayerController player;
    public const string Save_File_Name = @"\SaveGame.Sav";
    public KeyCode saveButton, loadButton;

    private void Update()
    {
        if(Input.GetKeyDown(saveButton))
        {
            SaveGame();
        }
        if(Input.GetKeyDown(loadButton))
        {
            LoadGame();
        }
    }
    private void SaveGame()
    {
        string PlayerPositionJson = JsonUtility.ToJson(player.transform.position, false);
        TextWriter writer = null;
        writer = new StreamWriter(Application.persistentDataPath + Save_File_Name);
        writer.Write(PlayerPositionJson);
        if (writer != null)
            writer.Close();
        
        
    }
    private void LoadGame()
    {

    }

}
