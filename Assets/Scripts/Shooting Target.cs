using UnityEngine;

namespace Ag3959
{
    public class ShootingTarget : MonoBehaviour
    {
        [SerializeField] private Transform[] targetEndPoints;

        public float speed = 1.0f;          // Adjust the speed for the application.


        private Transform target;           // The target (cylinder) position.

        private int currentEndPointIndex = 0;
        void Start()
        {
            target = targetEndPoints[0];
        }

        void Update()
        {
            // Move our position a step closer to the target.

            var step = speed * Time.deltaTime; // calculate distance to move
            transform.position = Vector3.MoveTowards(transform.position, target.position, step);


            // Check if the position of the cube and sphere are approximately equal.

            if (Vector3.Distance(transform.position, target.position) < 0.001f)
            {
                SwapEndPointTarget();                 // Swap the position of the cylinder.

            }

            void SwapEndPointTarget()

            {
                currentEndPointIndex++;
                currentEndPointIndex = targetEndPoints.Length;
                target = targetEndPoints[currentEndPointIndex];

            }
        }
    }
}
