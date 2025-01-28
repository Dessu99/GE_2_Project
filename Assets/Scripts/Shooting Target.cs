using UnityEngine;

namespace Ag3959
{
    public class ShootingTarget : MonoBehaviour
    {
        [SerializeField] private Transform[] targetEndPoints;
        private int currentEndPointIndex = 0;
        private Transform target;                               // The target (cylinder) position.
        public float speed = 1.0f;                              // Adjust the speed for the application.




        void Start()
        {
            target = targetEndPoints[0];
        }

        void Update()
        {

            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);



            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                SwapEndPointTarget();               
            }

            void SwapEndPointTarget()

            {
                currentEndPointIndex++;
                currentEndPointIndex %= targetEndPoints.Length;
                target = targetEndPoints[currentEndPointIndex];

            }
        }
    }
}
