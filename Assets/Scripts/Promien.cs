using UnityEngine;
using System.Collections;
public class Promien : MonoBehaviour
{


    [SerializeField] private GameObject bulletPrefab;
    private GameObject bullet;
    private Camera _camera;
    void Start()
    {

        _camera = GetComponent<Camera>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    void Update()
    {
        if (Time.timeScale == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {

                FindObjectOfType<AudioManager>().Play("Strza�");
                Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.
                pixelHeight / 2, 0);
                Ray ray = _camera.ScreenPointToRay(point);
                RaycastHit hit;
                if (Physics.Raycast(ray, out hit))
                {
                    GameObject hitObject = hit.transform.gameObject;
                    ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
                    if (target != null)
                    {
                        target.ReactToHit();
                    }
                    else
                    {
                        StartCoroutine(SphereIndicator(hit.point));
                    }

                }
            }
        }
    }
    private IEnumerator SphereIndicator(Vector3 pos)
    {

        bullet = Instantiate(bulletPrefab) as GameObject;
        bullet.transform.position = pos;
        yield return new WaitForSeconds(1);
        Destroy(bullet);
    }
    void OnGUI()
    {
        int size = 12;
        float posX = _camera.pixelWidth / 2 - size / 4;
        float posY = _camera.pixelHeight / 2 - size / 2;
        GUI.Label(new Rect(posX, posY, size, size), "*");
    }


}
