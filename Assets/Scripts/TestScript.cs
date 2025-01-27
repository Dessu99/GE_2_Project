using UnityEngine;

namespace AG3959
{
    public class TestScript : MonoBehaviour
    {

        [SerializeField] Transform target;
        [SerializeField] float bustANumber = 5.0f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // target = FindAnyObjectByType<DiceManager>().transform;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }

}