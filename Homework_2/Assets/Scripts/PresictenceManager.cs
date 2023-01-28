using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class PresictenceManager : MonoBehaviour
{
    [SerializeField] PlayerController player;
    public const string Save_File_Name = @"\SaveGame.Sav";
    public KeyCode saveButton, loadButton;

    private void Update()
    {
        if (Input.GetKeyDown(saveButton))
        {
            SaveGame();
        }
        if (Input.GetKeyDown(loadButton))
        {
            LoadGame();
        }
    }
    private void SaveGame()
    {
        string PlayerPositionJson = JsonUtility.ToJson( (Serilize_Transform) player.transform, false);
        TextWriter writer = null;
        writer = new StreamWriter(Application.persistentDataPath + Save_File_Name);
        writer.Write(PlayerPositionJson);
        if (writer != null)
            writer.Close();


    }
    private void LoadGame()
    { Serilize_Transform playerLastPos = null;
        TextReader reader = null;
        reader = new StreamReader(Application.persistentDataPath + Save_File_Name);
        string fileContents = reader.ReadToEnd();

        playerLastPos = JsonUtility.FromJson<Serilize_Transform>(fileContents);
        player.transform.position = new Vector3(playerLastPos.positionX, playerLastPos.positionY, playerLastPos.positionZ);
        player.transform.rotation = new Quaternion(playerLastPos.rotaisonX, playerLastPos.rotaisonY, playerLastPos.rotaisonZ, playerLastPos.rotaisonW);

    }

}

