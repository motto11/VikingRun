using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator : MonoBehaviour
{
    public GameObject Repeat;
    public GameObject fence;
    public GameObject platform;
    public GameObject right;
    public GameObject left;
    public int n;
    public static int direction = 0;
    public static int x = 0;
    public static int z = 8;

    private void OnTriggerEnter(Collider other)
    {
        n = Random.Range(0, 10);
        if (n <= 6)
        {
            GameObject r;
            switch (direction)
            {
                case 0:
                    z++;
                    r = Instantiate(Repeat, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    break;
                case 1:
                    x++;
                    r = Instantiate(Repeat, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    r.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    break;
                case 2:
                    z--;
                    r = Instantiate(Repeat, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    r.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    break;
                case 3:
                    x--;
                    r = Instantiate(Repeat, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    r.transform.localRotation = Quaternion.Euler(0, 270, 0);
                    break;
            }
        }
        else if (n == 7)
        {
            GameObject p;
            switch (direction)
            {
                case 0:
                    z++;
                    p = Instantiate(platform, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    break;
                case 1:
                    x++;
                    p = Instantiate(platform, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    p.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    break;
                case 2:
                    z--;
                    p = Instantiate(platform, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    p.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    break;
                case 3:
                    x--;
                    p = Instantiate(platform, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    p.transform.localRotation = Quaternion.Euler(0, 270, 0);
                    break;
            }
        }
        else if (n == 8)
        {
            GameObject ri;
            switch (direction)
            {
                case 0:
                    z++;
                    ri = Instantiate(right, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    break;
                case 1:
                    x++;
                    ri = Instantiate(right, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    ri.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    break;
                case 2:
                    z--;
                    ri = Instantiate(right, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    ri.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    break;
                case 3:
                    x--;
                    ri = Instantiate(right, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    ri.transform.localRotation = Quaternion.Euler(0, 270, 0);
                    break;
            }
            if (direction == 3)
                direction = 0;
            else
                direction++;
        }
        else if(n == 9)
        {
            GameObject l;
            switch (direction)
            {
                case 0:
                    z++;
                    l = Instantiate(left, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    break;
                case 1:
                    x++;
                    l = Instantiate(left, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    l.transform.localRotation = Quaternion.Euler(0, 90, 0);
                    break;
                case 2:
                    z--;
                    l = Instantiate(left, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    l.transform.localRotation = Quaternion.Euler(0, 180, 0);
                    break;
                case 3:
                    x--;
                    l = Instantiate(left, new Vector3(x * 8, 0, z * 8)
                        , new Quaternion(0, 0, 0, 0));
                    l.transform.localRotation = Quaternion.Euler(0, 270, 0);
                    break;
            }
            if (direction == 0)
                direction = 3;
            else
                direction--;
        }
        if (n == 6 || n == 5)
        {
            GameObject f;
            if (direction == 0 || direction == 2)
            {
                f = Instantiate(fence, new Vector3(x * 8, 1.25f, z * 8)
                    , new Quaternion(0, 0, 0, 0));
            }
            else
            {
                f = Instantiate(fence, new Vector3(x * 8, 1.25f, z * 8)
                    , new Quaternion(0, 0, 0, 0));
                f.transform.localRotation = Quaternion.Euler(0, 90, 0);
            }
        }
    }
    void Start()
    {
    }
    void Update()
    {
        
    }
}
