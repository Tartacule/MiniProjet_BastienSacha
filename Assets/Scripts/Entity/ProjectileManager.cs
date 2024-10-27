using Player;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.Serialization;

namespace Entity
{
    public class ProjectileManager : MonoBehaviour
    {   
        public float fullLaunchDelay;   //Time to press for full speed launch
        public float ld;                //Actual time held for launch
        public Inventory inv;           //Inventory to retrieve data from
        public AudioSource bowSound;
        
        private int _currentSlot;         //Currently selected slot
        private GameObject _pObject;    //Object to be launched
        private int _amount;            //Amount of arrows left
        private bool _equipped;         //Is an arrow about to be shot ?
        private bool _launched;         //Was the arrow launched ?

    
        void Start()
        {
            //Only if player has no arrows on startup
            /* if (amount <= 0) {
            throw new ArgumentException("Arrow amount is lower than 1!");
        }*/

            /*if (_inventory.slots.Count == 0)
        {
            Debug.Log("Empty inventory!");
        }*/
        }
    
        //Create instance of projectile when button is pressed
        public void StartLaunchProc()
        {
            _currentSlot = inv.selected;
            
            GameObject selectedObject = inv.itemList[_currentSlot].SO_InvSlot.Prefab;
            
            if (_equipped || inv.itemList[_currentSlot].amount == 0) {
                Debug.Log("No arrows Left to shoot!");
            }
            else {
                _pObject = Instantiate(selectedObject, transform.position, transform.rotation, this.transform);
                Debug.Log($"Object {_pObject} instantiated");
                _equipped = true;
                
                inv.itemList[_currentSlot].amount--;
            }
        }
    
        public void LaunchProjectile() {
            //Launches arrow at a fraction of launchSpeed, det. by % of time with btn held
            float normalizedLaunchSpeed = (ld / fullLaunchDelay) * _pObject.GetComponent<Arrow>().launchSpeed;
            _pObject.GetComponent<Arrow>().Launch(normalizedLaunchSpeed);
            bowSound.Play();
            _equipped = false;
        }

        public void Reset()
        {
            ld = 0;
        }
    }
}
