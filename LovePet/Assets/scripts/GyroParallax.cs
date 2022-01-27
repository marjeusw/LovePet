using UnityEngine;

public class GyroParallax : MonoBehaviour
{

    [SerializeField]
    private float shiftModifier = 2f;  //makes each row go with it´s own speed

    private Gyroscope gyro;


    
    // Start is called before the first frame update
    void Start()
    {
        gyro = Input.gyro;
        gyro.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((float)System.Math.Round(gyro.rotationRateUnbiased.y, 1) * shiftModifier, 0f, 0f);
    }


}
