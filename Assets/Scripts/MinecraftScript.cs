using UnityEngine;

public class MinecraftScript : MonoBehaviour
{
    [Range(0f, 1f)]
    public float power = 0.1f; 

    [Range(0f, 100f)]
    public float frequency = 2f; 

    private Vector3 baseScale;

    private void Start()
    {
        baseScale = transform.localScale;
    }

    private void Update()
    {
        float scaleOffset = Mathf.Sin(Time.time * frequency) * power;
        transform.localScale = baseScale * (1f + scaleOffset);
    }
}
