using UnityEngine;
using Unity.FPS.Game;
using Unity.FPS.UI;

namespace AG3959
{
    public class DamagableTarget : Damageable
    {
        public Renderer objectRenderer;
        public Color swapcolour = Color.green;
        public Color originalColour;
        public bool colourSwapped = false;
        private void Start()
        {
            objectRenderer = GetComponent<Renderer>();
            originalColour = GetComponent<Color>();

        }
        private void Awake()
        {
            

        }
        public override void InflictDamage(float damage, bool isExplosionDamage, GameObject damagesSouce)
        {
            base.InflictDamage(damage, isExplosionDamage, damagesSouce);

            SwapColour();
        }
        public void SwapColour()
        {
            if(!colourSwapped)
            {
                objectRenderer.material.color = swapcolour;
            }
            else
            {
                objectRenderer.material.color = originalColour;
            }
        }
        // Update is called once per frame
   
    }

}