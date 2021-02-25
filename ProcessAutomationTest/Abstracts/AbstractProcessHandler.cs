using ProcessAutomationTest.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProcessAutomationTest.Abstracts
{
    abstract class AbstractProcessHandler : IProcessHandler
    {
        public abstract void Execute(ref object payload);

        //private IProcessHandler _nextprocessHandler;
        //private IProcessHandler _errorProcessHandler;

        //public abstract void Execute();

        //public object Handle()
        //{
        //    try
        //    {
        //        Execute();

        //        return RunHandler(this._nextprocessHandler);
        //    }
        //    catch 
        //    {
        //        return RunHandler(this._errorProcessHandler);
        //    }            
        //}

        //private object RunHandler(IProcessHandler processHandler)
        //{
        //    if (processHandler != null)
        //    {
        //        return processHandler.Handle();
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}

        //public IProcessHandler SetError(IProcessHandler handler)
        //{
        //    this._errorProcessHandler = handler;

        //    return handler;
        //}

        //public IProcessHandler SetNext(IProcessHandler handler)
        //{
        //    this._nextprocessHandler = handler;

        //    return handler;
        //}

        //public IProcessHandler GetLastHandler()
        //{
        //    if (this._nextprocessHandler != null)
        //    {
        //        return _nextprocessHandler.GetLastHandler();
        //    }
        //    else
        //    {
        //        return this;
        //    }
        //}
    }
}
