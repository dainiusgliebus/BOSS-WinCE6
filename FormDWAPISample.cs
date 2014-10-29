//----------------------------------------------------------------------------------------
// FILENAME:		FormDWAPISample.cs
//
// Copyright(c) 2009 Motorola, Inc. All rights reserved.
//
// DESCRIPTION:		This simple application demonstrates
//					how to use the Motorola DataWedge API.
//					The API's used are as follows:
//
//					Start 
//					Stop 
//					Enable 
//					Disable
//					Get Status
//					On Start Event
//					On Stop Event
//					On Data Event
//                  
//----------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataWedgeLib;



namespace CSharpDWAPISample
{
    //----------------------------------------------------------------------------------------
    //
    //  FormDWAPISample: Main Form Class code
    //     
    //----------------------------------------------------------------------------------------
    public partial class FormDWAPISample : Form
    { 
        private DataWedgeAPI DWCtrl=null;
        private _IDataWedgeAPIEvents_OnStartEventHandler eventStart = null;
        private _IDataWedgeAPIEvents_OnStopEventHandler eventStop = null;
        private _IDataWedgeAPIEvents_OnDataEventHandler eventData = null;

        //----------------------------------------------------------------------------------------
        //
        //  FormDWAPISample: Main Form Class constructor
        //     
        //----------------------------------------------------------------------------------------
        public FormDWAPISample()
        {
            InitializeComponent();
            try
            {
                // Create an instance of Datawedge API Interface
                DWCtrl = new DataWedgeAPI();
                // Add OnStart Event Listener
                eventStart = new _IDataWedgeAPIEvents_OnStartEventHandler(Started);
                DWCtrl.OnStart += eventStart;
                // Add OnStop event listener
				eventStop = new _IDataWedgeAPIEvents_OnStopEventHandler(Stopped);
                DWCtrl.OnStop += eventStop;
                // Add OnData Event to handle status change events
				eventData = new _IDataWedgeAPIEvents_OnDataEventHandler(DataReceived);
                DWCtrl.OnData += eventData;
            }
            catch (Exception)
            {
                MessageBox.Show("DataWedge is not found!");
            }

        }

        //----------------------------------------------------------------------------------------
        //
        //  Started: On Start Event Handler function
        //     
        //----------------------------------------------------------------------------------------
        private void Started()
        {
            //Retreive the current status of DataWedge
            UpdateDWStatus(DWCtrl.status);

        }

        //----------------------------------------------------------------------------------------
        //
        //  Stopped: On Stop Event Handler function
        //     
        //----------------------------------------------------------------------------------------
        private void Stopped()
        {
            checkBoxRunning.CheckState = CheckState.Unchecked;
        }

        private void DataReceived(string strData)
        {
            /*  Incomming data received for OnData event can be
             *  proccessed by using simple string comparison or
             *  by loading the incomming xml string to a XML object.
             *  
             *  XML template of the OnData parameter 
             *      
             *      <status currentstatus='x' \>
             *      
             *      Root node - status
             *      attributes - currentstatus
             *      Child nodes - none
            */
            
            int nStatus = (int)DataWedgeLib.DataWedgeState.Stopped;
            //Check the currentstatus sttribute value.
            if (0 == strData.CompareTo("<status currentstatus=\'1\'/>"))
            {
                nStatus = (int)DataWedgeLib.DataWedgeState.Ready;
            }
            else if (0 == strData.CompareTo("<status currentstatus=\'2\'/>"))
            {
                nStatus = (int)DataWedgeLib.DataWedgeState.Disabled;
            }
            else if (0 == strData.CompareTo("<status currentstatus=\'4\'/>"))
            {
                nStatus = (int)DataWedgeLib.DataWedgeState.Idle;
            }
            UpdateDWStatus(nStatus);
            
        }

        //----------------------------------------------------------------------------------------
        //
        //  UpdateDWStatus: Common function to update the check box with the DataWedge status 
        //           input: nDWStatus
        //----------------------------------------------------------------------------------------
        private void UpdateDWStatus(int nDWStatus)
        {
            switch ((DataWedgeLib.DataWedgeState)nDWStatus)
            {
                case DataWedgeLib.DataWedgeState.Ready:
                    checkBoxRunning.CheckState = CheckState.Checked;
                    break;
                case DataWedgeLib.DataWedgeState.Idle:
                case DataWedgeLib.DataWedgeState.Disabled:
                case DataWedgeLib.DataWedgeState.Sleeping:
                    checkBoxRunning.CheckState = CheckState.Indeterminate;
                    break;
                case DataWedgeLib.DataWedgeState.Stopped:
                    checkBoxRunning.CheckState = CheckState.Unchecked;
                    break;
                default:
                    break;

            }
        }

        //----------------------------------------------------------------------------------------
        //
        //  btnStart_Click: Start button OnClick Handler 
        //     
        //----------------------------------------------------------------------------------------
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (DWCtrl == null)
                MessageBox.Show("DataWedge is not found!");
            else if (!DWCtrl.Start())
                MessageBox.Show("Start DataWedge failed.");
        }

        //----------------------------------------------------------------------------------------
        //
        //  btnStop_Click: Stop button OnClick Handler 
        //     
        //----------------------------------------------------------------------------------------
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (DWCtrl == null)
                MessageBox.Show("DataWedge is not found!");
            else if (!DWCtrl.Stop())
                MessageBox.Show("Stop DataWedge failed");
        }


        //----------------------------------------------------------------------------------------
        //
        //  btnEnable_Click: Enable button OnClick Handler 
        //     
        //----------------------------------------------------------------------------------------
        private void btnEnable_Click(object sender, EventArgs e)
        {
            bool persist = true;
            if (checkBoxPersist.CheckState == CheckState.Unchecked) persist = false;

            if (DWCtrl == null)
                MessageBox.Show("DataWedge is not found!");
            else if (!DWCtrl.Enable(persist))
                MessageBox.Show("Enable DataWedge failed");
        }

        //----------------------------------------------------------------------------------------
        //
        //  btnDisable_Click: Disable button OnClick Handler 
        //     
        //----------------------------------------------------------------------------------------
        private void btnDisable_Click(object sender, EventArgs e)
        {
            bool persist = true;
            if (checkBoxPersist.CheckState == CheckState.Unchecked) persist = false;

            if (DWCtrl == null)
                MessageBox.Show("DataWedge is not found!");
            else if (!DWCtrl.Disable(persist))
                MessageBox.Show("Disable DataWedge failed");
        }

        //----------------------------------------------------------------------------------------
        //
        //  btnGetStatus_Click: Status button OnClick Handler 
        //     
        //----------------------------------------------------------------------------------------
        private void btnGetStatus_Click(object sender, EventArgs e)
        {
            string strMsg = "DataWedge is not found!";
            if (DWCtrl != null)
            {
                int status = DWCtrl.status;
                strMsg = "Not Running";
                if (status == (int)DataWedgeLib.DataWedgeState.Disabled)
                    strMsg = "Disabled";
                if (status == (int)DataWedgeLib.DataWedgeState.Idle)
                    strMsg = "No capture device";
                if (status == (int)DataWedgeLib.DataWedgeState.Sleeping)
                    strMsg = "A Profile configuration is not loaded";
                if (status == (int)DataWedgeLib.DataWedgeState.Ready)
                    strMsg = "Running";
            }
            MessageBox.Show(strMsg);

        }


        //----------------------------------------------------------------------------------------
        //
        //  FormDWAPISample_Load: Onload event handler for the FormDWAPISample 
        //     
        //----------------------------------------------------------------------------------------
        private void FormDWAPISample_Load(object sender, EventArgs e)
        {
            // Update initial state
            if (DWCtrl != null)
            {
                int status = DWCtrl.status;
                UpdateDWStatus(status);
            }

        }

        private void FormDWAPISample_Closing(object sender, CancelEventArgs e)
        {
            ReleaseDataWedgeEvents();
        
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ReleaseDataWedgeEvents();
            Application.Exit();
        }

        private void ReleaseDataWedgeEvents()
        {
            try
            {
                DWCtrl.OnStart -= eventStart;
                DWCtrl.OnStop -= eventStop;
                DWCtrl.OnData -= eventData;
            }
            catch (Exception) { }
            while (System.Runtime.InteropServices.Marshal.ReleaseComObject(DWCtrl) > 0) ; 
   
        }

        private void btnDWVersion_Click(object sender, EventArgs e)
        {
            string strMsg = "DataWedge is not found!";
            if (DWCtrl != null && DWCtrl.DWVersion != null)
            {
                strMsg = DWCtrl.DWVersion;
            }
            MessageBox.Show(strMsg);

        }

        private void FormDWAPISample_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Rocker Up
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Rocker Down
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

    }
}
