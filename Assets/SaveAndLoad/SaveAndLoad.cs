using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using UnityEngine.SceneManagement;

public class SaveAndLoad : MonoBehaviour {

	public string level;

	public void save(){
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream file = File.Create (Application.persistentDataPath + "/simpananData.dat");

		PlayerData data = new PlayerData ();
		data.level = level;
		bf.Serialize (file, data);
		file.Close ();
	}

	public void load(){
		if (File.Exists (Application.persistentDataPath + "/simpananData.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream file = File.Open (Application.persistentDataPath + "/simpananData.dat", FileMode.Open);
			PlayerData data = (PlayerData)bf.Deserialize (file);
			file.Close ();

			level = data.level;
			SceneManager.LoadScene (level);
		}
	}
}

[Serializable]
class PlayerData{
	public string level;
}
