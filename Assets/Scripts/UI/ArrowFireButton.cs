using Entity;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UI
{
    public class ArrowFireButton : MonoBehaviour,IUpdateSelectedHandler, IPointerDownHandler, IPointerUpHandler
    {   
        [SerializeField] private ProjectileManager pm;
        
        public void OnUpdateSelected(BaseEventData eventData) {
            Debug.Log("OnUpdateSelected");
            pm.ld += Time.deltaTime;

            if (pm.ld > pm.fullLaunchDelay)
            {
                pm.LaunchProjectile();
                pm.Reset(); 
                return;
            }
        }

        public void OnPointerDown(PointerEventData eventData) {
            pm.StartLaunchProc();
        }

        public void OnPointerUp(PointerEventData eventData) {
            pm.LaunchProjectile();
            pm.Reset();
        }
    }
}
