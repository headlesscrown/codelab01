﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code.FSM.States
{

    [CreateAssetMenu(fileName ="IdleState", menuName ="Unity-FSM/States/Idle", order =1)] //create instance of state in editor, add menu in Unity window for access

    public class IdleState: AbstractFSMState
    {
        public override void OnEnable()
        {
            base.OnEnable();
            StateType = FSMStateType.IDLE;
        }

        public override bool EnterState() //call base implementation on abstract class
        {
            base.EnterState(); //enter state

            Debug.Log("entered idle state"); //show debug msg

            EnteredState = true; //successfully entry
            return EnteredState; //return
        }

        public override void UpdateState() //no error detected with idle state; preventative measure, stops compiler from generating errors*
        {
            //throw new NotImplementedException(); //throw exception every frame update

            Debug.Log("updating idle state"); //show debug msg
        }

        public override bool ExitState()
        {
            base.ExitState(); //call parent state

            Debug.Log("exiting idle state"); //show debug msg

            return true; //return
        }
    }
}
