﻿using ABBRobotLib.Definations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABBRobotLib.ABBCmd
{
    public class CmdCalibrate : RobotCmdBase
    {
        public CmdCalibrate()
        {
            I_Cmd = this.I_Cmd;
        }
        /// <summary>
        /// 标定点序号从1-9
        /// </summary>
        public int Index { get; set; }

        public double Q_X { get; set; }
        public double Q_Y { get; set; }
        public double Q_Z { get; set; }


        protected override void SetProfile()
        {
            Paras[0] = Index.ToString();
        }

        public override object GenEmptyCmd()
        {
            return new CmdCalibrate();
        }

        protected override void ReadProfile()
        {
            bool bRet = true;
            bRet &= double.TryParse(Paras[0], out double x);
            bRet &= double.TryParse(Paras[1], out double y);
            bRet &= double.TryParse(Paras[2], out double z);
            if (!bRet)
                throw new Exception("Wrong robot coordinate when parse calibdata");
            this.Q_X = x;
            this.Q_Y = y;
            this.Q_Z = z;
        }
    }
}
