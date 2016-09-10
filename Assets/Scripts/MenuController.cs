using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {
	public void Click(){
		Debug.Log("Button clicked");
		GameObject gameObject = GameObject.CreatePrimitive (PrimitiveType.Cube);
		gameObject.name = "new cube";
	}
}
