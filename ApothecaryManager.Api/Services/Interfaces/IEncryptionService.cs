using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApothecaryManager.WebApi.Services.Interfaces
{
    public interface IEncryptionService
    {
        byte[] CreateSalt(int size);

        byte[] EncryptHashWithSalt(string plainText, byte[] salt);

        bool CompareByteArrays(byte[] array1, byte[] array2);
    }
}
