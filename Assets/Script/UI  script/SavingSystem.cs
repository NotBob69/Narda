using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    /*
    public static void Save(DataToSave data)
    {

        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/dataSave" + data + ".inf";
        FileStream stream = new FileStream(path, FileMode.Create);


        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static bool LevelSaveCheck(int level)
    {

        string path = Application.persistentDataPath + "/levelSave" + level + ".inf";

        if (File.Exists(path))
            return true;
        else return false;


    }

    public static  LoadData(int level)
    {

        string path = Application.persistentDataPath + "/levelSave" + level + ".inf";

        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            LevelProgress data = formatter.Deserialize(stream) as LevelProgress;

            stream.Close();
            return data;


        }
        else
        {
            bool lvlPlayable;
            Debug.LogError("Save file not found in " + path);
            if (level == 1)
                lvlPlayable = true;
            else
                lvlPlayable = false;


            return new LevelProgress(level, lvlPlayable, 0, 0, 0f);

        }
    }
    */

}
