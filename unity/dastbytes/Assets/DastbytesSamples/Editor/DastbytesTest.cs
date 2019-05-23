using NUnit.Framework;
using Assert = UnityEngine.Assertions.Assert;

namespace Dastbytes {
public class Test {
  [Test]
  public void CheckUInt8(){
    byte pack_value = 0x12;
    byte[] bytes = new byte[ sizeof( byte ) ];
    Binary.PackUInt8( ref bytes, 0, pack_value );
    byte unpack_value = Binary.UnpackUInt8( bytes, 0 );
    Assert.AreEqual( pack_value, unpack_value );
  }
  
  [Test]
  public void CheckUInt16(){
    ushort pack_value = 0x1234;
    byte[] bytes = new byte[ sizeof( ushort ) ];
    Binary.PackUInt16( ref bytes, 0, pack_value );
    ushort unpack_value = Binary.UnpackUInt16( bytes, 0 );
    Assert.AreEqual( pack_value, unpack_value );
  }
  
  [Test]
  public void CheckUInt32(){
    uint pack_value = 0x12345678;
    byte[] bytes = new byte[ sizeof( uint ) ];
    Binary.PackUInt32( ref bytes, 0, pack_value );
    uint unpack_value = Binary.UnpackUInt32( bytes, 0 );
    Assert.AreEqual( pack_value, unpack_value );
  }
}
}
