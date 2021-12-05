using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TargetDestroy : MonoBehaviour
{

  

    void OnMouseDown()
    {
        GameObject.FindWithTag("GameManager").GetComponent<ScoreManager>().RaiseScore();
        Destroy(this.gameObject);

    }

}