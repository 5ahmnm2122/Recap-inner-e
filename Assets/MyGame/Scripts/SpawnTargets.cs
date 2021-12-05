using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnTargets : MonoBehaviour
{

   [SerializeField] GameObject target;
   [SerializeField] GameObject canvas;


    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine(SpawnTarget());
    }

   IEnumerator SpawnTarget()
    {
        int positionX = Random.Range(-960/2, 960/2);
        int positionY = Random.Range(-600/2, 600/2);
        GameObject targetInstance = Instantiate(target, canvas.transform);
        targetInstance.GetComponent<RectTransform>().localPosition = new Vector2(positionX, positionY);
        yield return new WaitForSeconds(2);
        StartCoroutine(SpawnTarget());
    }
}
