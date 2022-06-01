using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerHard : MonoBehaviour
{
    public GameObject target;
    public int xPos;
    public int zPos;
    public float yPos;
    public int targetCount;

    private void Start()
    {
        StartCoroutine(TargetDrop());
    }

    IEnumerator TargetDrop()
    {
        while (targetCount < 35)
        {
            xPos = Random.Range(-10, 11);
            zPos = Random.Range(10, 31);
            yPos = Random.Range(0.61f, 5);
            Instantiate(target, new Vector3(xPos, yPos, zPos), Quaternion.identity);
            yield return new WaitForSeconds(0.3f);
            targetCount += 1;
        }
    }
}
