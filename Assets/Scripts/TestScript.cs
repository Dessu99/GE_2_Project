using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

namespace AG3959
{
    public class TestScript : MonoBehaviour
    {

        [SerializeField] Transform target;
        [SerializeField] float bustANumber = 5.0f;
        [SerializeField] List<GameObject> listOfObjects;

        // Changing the names of things as a whole ctrl + r and rename them all at the same time, easier for changing online scripts

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