﻿using System.IO;

namespace ExcelTrans.Commands
{
    public struct PopSet : IExcelCommand
    {
        void IExcelCommand.Read(BinaryReader r) { }
        void IExcelCommand.Write(BinaryWriter w) { }
        void IExcelCommand.Execute(IExcelContext ctx) => ctx.Sets.Pop().Execute(ctx);

        internal static void Reset(IExcelContext ctx, int idx)
        {
            while (ctx.Sets.Count > idx)
                ctx.Sets.Pop().Execute(ctx);
        }
    }
}