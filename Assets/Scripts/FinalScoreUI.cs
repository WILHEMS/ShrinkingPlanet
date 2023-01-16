using UnityEngine.UI;
using UnityEngine;
using PhotonNetwork.Pun;

[RequireComponent(typeof(Text))]
public class FinalScoreUI : MonoBehaviour {

	void Start ()
	{
		GetComponent<Text>().text = "d = <i><b>" + Planet.Score.ToString("0.#") + "</b>m</i>";
	}

}
