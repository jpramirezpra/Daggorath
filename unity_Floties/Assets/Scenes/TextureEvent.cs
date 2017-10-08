using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TextureEvent : GvrAllEventsTrigger {
    public static string materialname;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TestFunction(BaseEventData flotie)
    {
		if (materialname == null) {
			Debug.Log (materialname);
			materialname = this.GetComponent<Renderer> ().material.name;
		} else {
			Debug.Log (materialname);
			string resourceToLoad = materialname.Substring(0, materialname.IndexOf(" "));
			Debug.Log (resourceToLoad);
			Material mat = Resources.Load (resourceToLoad, typeof(Material)) as Material;
			materialname = this.GetComponent<Renderer> ().material.name;
			Debug.Log (mat.name);
			this.GetComponent<Renderer>().sharedMaterial = mat;
		}
    }

	public void GetPaint(BaseEventData flotie)
    {
		string mat = this.GetComponent<Renderer>().material.name;
		materialname = mat.Substring(0, mat.IndexOf(" "));
    }

	public void PaintObject(BaseEventData flotie){
		Material mat = Resources.Load (materialname, typeof(Material)) as Material;
		Debug.Log (mat);
		if (mat != null) {
			this.GetComponent<Renderer>().sharedMaterial = mat;
		}
	}

}

