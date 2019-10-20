﻿using AdTrack.Data;
using BigSoft.Framework.Util;
using System;
using System.Diagnostics;
using System.Reflection;

namespace AdTrack.Business
{
    public abstract class AdOperations
    {
        public BsNewResult Result { get; set; } = new BsNewResult();

        public BsNewResult Execute()
        {
            try
            {
                MethodBase methodBase = new StackFrame(1).GetMethod();
                if (methodBase.ReflectedType != null)
                    BsTrace.WriteLine("", methodBase.ReflectedType.Name + " - " + methodBase.Name, TraceLvl.INF);
                DoJob();
                if (Result.OpType == OpType.Successful)
                    Result.Message = "Başarıyla tamamlandı";
            }
            catch (BsException ex)
            {
                Result.Message = ex.Message;
                Result.OpType = ex.OpType;
            }
            catch (Exception ex)
            {
                Result.Message = ex.Message;
                Result.OpType = OpType.SystemError;
                Result.Exception = ex.InnerException;
                BsTrace.WriteLine(ex.Message, GetType().Name, TraceLvl.ERR);
            }

            return Result;
        }

        protected abstract void DoJob();
    }
}