using UnityEngine;

//tanner brewer 2023

namespace Hotshot
{
    public class InteractEvent : Subject {
    
	    public void Notify() {

            NotifyObservers();

        }

    }
}
