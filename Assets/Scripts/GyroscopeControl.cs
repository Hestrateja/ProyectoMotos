using UnityEngine;
using UnityEngine.UI;

public class GyroscopeControl : MonoBehaviour
{
    public UnityEngine.Gyroscope gyro;
    public Text text;
    float dirX;
    float moveSpeed = 20f;

    private void Start()
    {
        if (SystemInfo.supportsGyroscope)
        {
            gyro = Input.gyro;
            gyro.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        if (SystemInfo.supportsGyroscope)
        {
            transform.rotation = GyroToUnity(Input.gyro.attitude);
            text.text = "input.gyro.attitude: " + Input.gyro.attitude;
            transform.position = new Vector3(Mathf.Clamp(Input.acceleration.x,-5f,5f), 0, Mathf.Clamp(-Input.acceleration.z,0,7.5f));
        }
            

    }
    private Quaternion Girar(Quaternion q)
    {
        return new Quaternion(0, 0, -q.z, 1);
    }
    private Quaternion GyroToUnity(Quaternion q)
    {
        return new Quaternion(q.x, q.y, -q.z, -q.w);
    }
}