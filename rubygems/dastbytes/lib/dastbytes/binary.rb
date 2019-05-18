module Dastbytes
  class Binary
    def self.pack( type, value )
      values = [ value ]
      case type
      when :uint8
        values.pack( "C*" )
      when :uint16
        values.pack( "v*" )
      when :uint32
        values.pack( "V*" )
      end
    end
    
    def self.unpack( type, value )
      case type
      when :uint8
        value.unpack( "C*" )
      when :uint16
        value.unpack( "v*" )
      when :uint32
        value.unpack( "V*" )
      end
    end
  end
end
