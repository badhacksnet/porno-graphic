<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Capcom Play System 1"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
  <layouts>
    <layout name="8x8">
      <plane multiplier="8">
        <offset bits="3" />
        <offset bits="2" />
        <offset bits="1" />
        <offset bits="0" />
      </plane>
      <x multiplier="1">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
        <offset bits="4" />
        <offset bits="5" />
        <offset bits="6" />
        <offset bits="7" />
      </x>
      <y multiplier="64">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
        <offset bits="4" />
        <offset bits="5" />
        <offset bits="6" />
        <offset bits="7" />
      </y>
      <stride>512</stride>
    </layout>

    <layout name="8x8 2">
      <plane multiplier="8">
        <offset bits="3" />
        <offset bits="2" />
        <offset bits="1" />
        <offset bits="0" />
      </plane>
      <x multiplier="1">
        <offset bits="32" />
        <offset bits="33" />
        <offset bits="34" />
        <offset bits="35" />
        <offset bits="36" />
        <offset bits="37" />
        <offset bits="38" />
        <offset bits="39" />
      </x>
      <y multiplier="64">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
        <offset bits="4" />
        <offset bits="5" />
        <offset bits="6" />
        <offset bits="7" />
      </y>
      <stride>512</stride>
    </layout>

    <layout name="16x16">
      <plane multiplier="8">
        <offset bits="3" />
        <offset bits="2" />
        <offset bits="1" />
        <offset bits="0" />
      </plane>
      <x multiplier="1">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
        <offset bits="4" />
        <offset bits="5" />
        <offset bits="6" />
        <offset bits="7" />
        <offset bits="32" />
        <offset bits="33" />
        <offset bits="34" />
        <offset bits="35" />
        <offset bits="36" />
        <offset bits="37" />
        <offset bits="38" />
        <offset bits="39" />
      </x>
      <y multiplier="64">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
        <offset bits="4" />
        <offset bits="5" />
        <offset bits="6" />
        <offset bits="7" />
        <offset bits="8" />
        <offset bits="9" />
        <offset bits="10" />
        <offset bits="11" />
        <offset bits="12" />
        <offset bits="13" />
        <offset bits="14" />
        <offset bits="15" />
      </y>
      <stride>1024</stride>
    </layout>

    <layout name="32x32">
      <plane multiplier="8">
        <offset bits="3" />
        <offset bits="2" />
        <offset bits="1" />
        <offset bits="0" />
      </plane>
      <x multiplier="1">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
        <offset bits="4" />
        <offset bits="5" />
        <offset bits="6" />
        <offset bits="7" />
        <offset bits="32" />
        <offset bits="33" />
        <offset bits="34" />
        <offset bits="35" />
        <offset bits="36" />
        <offset bits="37" />
        <offset bits="38" />
        <offset bits="39" />
        <offset bits="64" />
        <offset bits="65" />
        <offset bits="66" />
        <offset bits="67" />
        <offset bits="68" />
        <offset bits="69" />
        <offset bits="70" />
        <offset bits="71" />
        <offset bits="96" />
        <offset bits="97" />
        <offset bits="98" />
        <offset bits="99" />
        <offset bits="100" />
        <offset bits="101" />
        <offset bits="102" />
        <offset bits="103" />
      </x>
      <y multiplier="128">
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
        <offset bits="4" />
        <offset bits="5" />
        <offset bits="6" />
        <offset bits="7" />
        <offset bits="8" />
        <offset bits="9" />
        <offset bits="10" />
        <offset bits="11" />
        <offset bits="12" />
        <offset bits="13" />
        <offset bits="14" />
        <offset bits="15" />
        <offset bits="16" />
        <offset bits="17" />
        <offset bits="18" />
        <offset bits="19" />
        <offset bits="20" />
        <offset bits="21" />
        <offset bits="22" />
        <offset bits="23" />
        <offset bits="24" />
        <offset bits="25" />
        <offset bits="26" />
        <offset bits="27" />
        <offset bits="28" />
        <offset bits="29" />
        <offset bits="30" />
        <offset bits="31" />
      </y>
      <stride>4096</stride>
    </layout>
  </layouts>

  <regions>
    <region name="Forgotten Worlds 88621B-2" length="400000">
      <file name="2b" lanes="64/byte">
        <load offset="000000" size="20000" />
      </file>
      <file name="2a" lanes="64/byte">
        <load offset="000001" size="20000" />
      </file>
      <file name="9b" lanes="64/word">
        <load offset="000002" size="80000" />
      </file>
      <file name="5e" lanes="64/byte">
        <load offset="000004" size="20000" />
      </file>
      <file name="5c" lanes="64/byte">
        <load offset="000005" size="20000" />
      </file>
      <file name="8h" lanes="64/byte">
        <load offset="000006" size="20000" />
      </file>
      <file name="8f" lanes="64/byte">
        <load offset="000007" size="20000" />
      </file>
      <file name="3b" lanes="64/byte">
        <load offset="100000" size="20000" />
      </file>
      <file name="3a" lanes="64/byte">
        <load offset="100001" size="20000" />
      </file>
      <file name="7e" lanes="64/byte">
        <load offset="100004" size="20000" />
      </file>
      <file name="7c" lanes="64/byte">
        <load offset="100005" size="20000" />
      </file>
      <file name="9h" lanes="64/byte">
        <load offset="100006" size="20000" />
      </file>
      <file name="9f" lanes="64/byte">
        <load offset="100007" size="20000" />
      </file>
      <file name="6b" lanes="64/word">
        <load offset="200000" size="80000" />
      </file>
      <file name="10b" lanes="64/byte">
        <load offset="200002" size="20000" />
      </file>
      <file name="10a" lanes="64/word">
        <load offset="200003" size="20000" />
      </file>
      <file name="9d" lanes="64/word">
        <load offset="200004" size="80000" />
      </file>
      <file name="10e" lanes="64/byte">
        <load offset="200006" size="20000" />
      </file>
      <file name="10c" lanes="64/byte">
        <load offset="200007" size="20000" />
      </file>
      <file name="11b" lanes="64/byte">
        <load offset="300002" size="20000" />
      </file>
      <file name="11a" lanes="64/byte">
        <load offset="300003" size="20000" />
      </file>
      <file name="11e" lanes="64/byte">
        <load offset="300006" size="20000" />
      </file>
      <file name="11c" lanes="64/byte">
        <load offset="300007" size="20000" />
      </file>
    </region>
  </regions>
</profile:profile>