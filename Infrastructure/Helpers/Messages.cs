using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Helpers
{
    public static class Messages
    {
        public const string ReceiptObj = "No Need To save as Receipt Amount is ZERO";
        public const string StudentSave = "Student Record Saved;Serial No: ";
        public const string Balance = "Old Balance Of Last Academic Year";
        public const string RegIncorrect = "Incorrect Reg No/Serial No, PLEASE CHECK";
        public const string NotAdmitted = "Student Not Granted Admission";
        public const string RegGenerated = "Registration Numbers Generated Successfully";
        public const string EffectiveDate = "Record(s) Cannot be Edited as Effective Date Already Passed";
        public const string Exception = "There is some system problem.";
        public const string RecordExist = "Record already exists.";
        public const string RecordUpdated = "Record Updated successfully.";
        public const string RecordAdded = "Record Added successfully.";
        public const string RecordDeleted = "Record Deleted successfully.";
        public const string RecordUsed = "Record cannot be deleted as dependent record(s) exist.";
    }
}
