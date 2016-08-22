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
    <region name="Forgotten Worlds 88618B-2" length="400000">
      <file name="9d" lanes="64/word">
        <load offset="000000" size="80000" />
      </file>
      <file name="9f" lanes="64/word">
        <load offset="000002" size="80000" />
      </file>
      <file name="9e" lanes="64/word">
        <load offset="000004" size="80000" />
      </file>
      <file name="9g" lanes="64/word">
        <load offset="000006" size="80000" />
      </file>
      <file name="12d" lanes="64/word">
        <load offset="200000" size="80000" />
      </file>
      <file name="12f" lanes="64/word">
        <load offset="200002" size="80000" />
      </file>
      <file name="12e" lanes="64/word">
        <load offset="200004" size="80000" />
      </file>
      <file name="12g" lanes="64/word">
        <load offset="200006" size="80000" />
      </file>
    </region>

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

    <region name="Ghouls'n'Ghosts 88620B-2/88620B-?" length="300000">
      <file name="3a" lanes="64/word">
        <load offset="000000" size="80000" />
      </file>
      <file name="3f" lanes="64/word">
        <load offset="000002" size="80000" />
      </file>
      <file name="3c" lanes="64/word">
        <load offset="000004" size="80000" />
      </file>
      <file name="3g" lanes="64/word">
        <load offset="000006" size="80000" />
      </file>
      <file name="4a" lanes="64/byte">
        <load offset="200000" size="10000" />
      </file>
      <file name="7a" lanes="64/byte">
        <load offset="200001" size="10000" />
      </file>
      <file name="4e" lanes="64/byte">
        <load offset="200002" size="10000" />
      </file>
      <file name="7e" lanes="64/byte">
        <load offset="200003" size="10000" />
      </file>
      <file name="4c" lanes="64/byte">
        <load offset="200004" size="10000" />
      </file>
      <file name="7c" lanes="64/byte">
        <load offset="200005" size="10000" />
      </file>
      <file name="4g" lanes="64/byte">
        <load offset="200006" size="10000" />
      </file>
      <file name="7g" lanes="64/byte">
        <load offset="200007" size="10000" />
      </file>
      <file name="4b" lanes="64/byte">
        <load offset="280000" size="10000" />
      </file>
      <file name="7b" lanes="64/byte">
        <load offset="280001" size="10000" />
      </file>
      <file name="4f" lanes="64/byte">
        <load offset="280002" size="10000" />
      </file>
      <file name="7f" lanes="64/byte">
        <load offset="280003" size="10000" />
      </file>
      <file name="4d" lanes="64/byte">
        <load offset="280004" size="10000" />
      </file>
      <file name="7d" lanes="64/byte">
        <load offset="280005" size="10000" />
      </file>
      <file name="4h" lanes="64/byte">
        <load offset="280006" size="10000" />
      </file>
      <file name="7h" lanes="64/byte">
        <load offset="280007" size="10000" />
      </file>
    </region>

    <region name="Daimakaimura 88622B-2" length="300000">
      <file name="4b" lanes="64/byte">
        <load offset="000000" size="20000" />
      </file>
      <file name="4a" lanes="64/byte">
        <load offset="000001" size="20000" />
      </file>
      <file name="9b" lanes="64/byte">
        <load offset="000002" size="20000" />
      </file>
      <file name="9a" lanes="64/byte">
        <load offset="000003" size="20000" />
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
      <file name="5b" lanes="64/byte">
        <load offset="100000" size="20000" />
      </file>
      <file name="5a" lanes="64/byte">
        <load offset="100001" size="20000" />
      </file>
      <file name="10b" lanes="64/byte">
        <load offset="100002" size="20000" />
      </file>
      <file name="10a" lanes="64/byte">
        <load offset="100003" size="20000" />
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
      <file name="7b" lanes="64/byte">
        <load offset="200000" size="10000" />
      </file>
      <file name="7a" lanes="64/byte">
        <load offset="200001" size="10000" />
      </file>
      <file name="11b" lanes="64/byte">
        <load offset="200002" size="10000" />
      </file>
      <file name="11a" lanes="64/byte">
        <load offset="200003" size="10000" />
      </file>
      <file name="8e" lanes="64/byte">
        <load offset="200004" size="10000" />
      </file>
      <file name="8c" lanes="64/byte">
        <load offset="200005" size="10000" />
      </file>
      <file name="10e" lanes="64/byte">
        <load offset="200006" size="10000" />
      </file>
      <file name="10c" lanes="64/byte">
        <load offset="200007" size="10000" />
      </file>
      <file name="8b" lanes="64/byte">
        <load offset="280000" size="10000" />
      </file>
      <file name="8a" lanes="64/byte">
        <load offset="280001" size="10000" />
      </file>
      <file name="12b" lanes="64/byte">
        <load offset="280002" size="10000" />
      </file>
      <file name="12a" lanes="64/byte">
        <load offset="280003" size="10000" />
      </file>
      <file name="9e" lanes="64/byte">
        <load offset="280004" size="10000" />
      </file>
      <file name="9c" lanes="64/byte">
        <load offset="280005" size="10000" />
      </file>
      <file name="11e" lanes="64/byte">
        <load offset="280006" size="10000" />
      </file>
      <file name="11c" lanes="64/byte">
        <load offset="280007" size="10000" />
      </file>
    </region>

    <region name="Daimakaimura/Dynasty Wars 91634B-2" length="400000">
      <file name="3a" lanes="64/word">
        <load offset="000000" size="80000" />
      </file>
      <file name="4a" lanes="64/word">
        <load offset="000002" size="80000" />
      </file>
      <file name="5a" lanes="64/word">
        <load offset="000004" size="80000" />
      </file>
      <file name="6a" lanes="64/word">
        <load offset="000006" size="80000" />
      </file>
      <file name="7a" lanes="64/word">
        <load offset="200000" size="80000" />
      </file>
      <file name="8a" lanes="64/word">
        <load offset="200002" size="80000" />
      </file>
      <file name="9a" lanes="64/word">
        <load offset="200004" size="80000" />
      </file>
      <file name="10a" lanes="64/word">
        <load offset="200006" size="80000" />
      </file>
    </region>

    <region name="Strider 89624B-3/91634B-2" length="400000">
      <file name="8a" lanes="64/word">
        <load offset="000000" size="80000" />
      </file>
      <file name="10a" lanes="64/word">
        <load offset="000002" size="80000" />
      </file>
      <file name="4a" lanes="64/word">
        <load offset="000004" size="80000" />
      </file>
      <file name="6a" lanes="64/word">
        <load offset="000006" size="80000" />
      </file>
      <file name="7a" lanes="64/word">
        <load offset="200000" size="80000" />
      </file>
      <file name="9a" lanes="64/word">
        <load offset="200002" size="80000" />
      </file>
      <file name="3a" lanes="64/word">
        <load offset="200004" size="80000" />
      </file>
      <file name="5a" lanes="64/word">
        <load offset="200006" size="80000" />
      </file>
    </region>

    <region name="Strider 90629B-3" length="400000">
      <file name="8a" lanes="64/word">
        <load offset="000000" size="80000" />
      </file>
      <file name="10a" lanes="64/word">
        <load offset="000002" size="80000" />
      </file>
      <file name="7a" lanes="64/word">
        <load offset="000004" size="80000" />
      </file>
      <file name="9a" lanes="64/word">
        <load offset="000006" size="80000" />
      </file>
      <file name="8c" lanes="64/word">
        <load offset="200000" size="80000" />
      </file>
      <file name="10c" lanes="64/word">
        <load offset="200002" size="80000" />
      </file>
      <file name="7c" lanes="64/word">
        <load offset="200004" size="80000" />
      </file>
      <file name="9c" lanes="64/word">
        <load offset="200006" size="80000" />
      </file>
    </region>

    <region name="Strider/Dynasty Wars/Willow 88622B-3" length="400000">
      <file name="4b" lanes="64/byte">
        <load offset="000000" size="20000" />
      </file>
      <file name="4a" lanes="64/byte">
        <load offset="000001" size="20000" />
      </file>
      <file name="9b" lanes="64/byte">
        <load offset="000002" size="20000" />
      </file>
      <file name="9a" lanes="64/byte">
        <load offset="000003" size="20000" />
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
      <file name="5b" lanes="64/byte">
        <load offset="100000" size="20000" />
      </file>
      <file name="5a" lanes="64/byte">
        <load offset="100001" size="20000" />
      </file>
      <file name="10b" lanes="64/byte">
        <load offset="100002" size="20000" />
      </file>
      <file name="10a" lanes="64/byte">
        <load offset="100003" size="20000" />
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
      <file name="7b" lanes="64/byte">
        <load offset="200000" size="10000" />
      </file>
      <file name="7a" lanes="64/byte">
        <load offset="200001" size="20000" />
      </file>
      <file name="11b" lanes="64/byte">
        <load offset="200002" size="20000" />
      </file>
      <file name="11a" lanes="64/byte">
        <load offset="200003" size="20000" />
      </file>
      <file name="8e" lanes="64/byte">
        <load offset="200004" size="20000" />
      </file>
      <file name="8c" lanes="64/byte">
        <load offset="200005" size="20000" />
      </file>
      <file name="10e" lanes="64/byte">
        <load offset="200006" size="20000" />
      </file>
      <file name="10c" lanes="64/byte">
        <load offset="200007" size="20000" />
      </file>
      <file name="8b" lanes="64/byte">
        <load offset="300000" size="20000" />
      </file>
      <file name="8a" lanes="64/byte">
        <load offset="300001" size="20000" />
      </file>
      <file name="12b" lanes="64/byte">
        <load offset="300002" size="20000" />
      </file>
      <file name="12a" lanes="64/byte">
        <load offset="300003" size="20000" />
      </file>
      <file name="9e" lanes="64/byte">
        <load offset="300004" size="20000" />
      </file>
      <file name="9c" lanes="64/byte">
        <load offset="300005" size="20000" />
      </file>
      <file name="11e" lanes="64/byte">
        <load offset="300006" size="20000" />
      </file>
      <file name="11c" lanes="64/byte">
        <load offset="300007" size="20000" />
      </file>
    </region>

    <region name="Dynasty Wars 89624B-?" length="400000">
      <file name="7a" lanes="64/word">
        <load offset="000000" size="80000" />
      </file>
      <file name="9a" lanes="64/word">
        <load offset="000002" size="80000" />
      </file>
      <file name="3a" lanes="64/word">
        <load offset="000004" size="80000" />
      </file>
      <file name="5a" lanes="64/word">
        <load offset="000006" size="80000" />
      </file>
      <file name="8a" lanes="64/word">
        <load offset="200000" size="80000" />
      </file>
      <file name="10a" lanes="64/word">
        <load offset="200002" size="80000" />
      </file>
      <file name="4a" lanes="64/word">
        <load offset="200004" size="80000" />
      </file>
      <file name="6a" lanes="64/word">
        <load offset="200006" size="80000" />
      </file>
    </region>

    <region name="Willow 89624B-3" length="400000">
      <file name="7a" lanes="64/word">
        <load offset="000000" size="80000" />
      </file>
      <file name="9a" lanes="64/word">
        <load offset="000002" size="80000" />
      </file>
      <file name="3a" lanes="64/word">
        <load offset="000004" size="80000" />
      </file>
      <file name="5a" lanes="64/word">
        <load offset="000006" size="80000" />
      </file>
      <file name="7d" lanes="64/word">
        <load offset="200000" size="20000" />
      </file>
      <file name="7c" lanes="64/word">
        <load offset="200001" size="20000" />
      </file>
      <file name="9d" lanes="64/word">
        <load offset="200002" size="20000" />
      </file>
      <file name="9c" lanes="64/word">
        <load offset="200003" size="20000" />
      </file>
      <file name="3d" lanes="64/word">
        <load offset="200004" size="20000" />
      </file>
      <file name="3c" lanes="64/word">
        <load offset="200005" size="20000" />
      </file>
      <file name="5d" lanes="64/word">
        <load offset="200006" size="20000" />
      </file>
      <file name="5c" lanes="64/word">
        <load offset="200007" size="20000" />
      </file>
    </region>
	<region name = "Final Fight/1941/Mercs 89624B-3 (World and USA)" length="200000">
	  <file name="7a" lanes="64/word">
        <load offset="000000" size="80000" />
     </file>
	 <file name="9a" lanes="64/word">
        <load offset="000002" size="80000" />
     </file>
	 <file name="3a" lanes="64/word">
        <load offset="000004" size="80000" />
     </file>
	 <file name="5a" lanes="64/word">
        <load offset="000006" size="80000" />
     </file>
	</region>
		<region name = "Final Fight/1941/Mercs 88622B-3/89625B-1 (Japan)" length="200000">
	  <file name="4b" lanes="64/byte">
        <load offset="000000" size="20000" />
     </file>
	 <file name="4a" lanes="64/byte">
        <load offset="000001" size="20000" />
     </file>
	 <file name="9b" lanes="64/byte">
        <load offset="000002" size="20000" />
     </file>
	 <file name="9a" lanes="64/byte">
        <load offset="000003" size="20000" />
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
	 <file name="5b" lanes="64/byte">
        <load offset="100000" size="20000" />
     </file>
	 <file name="5a" lanes="64/byte">
        <load offset="100001" size="20000" />
     </file>
	 <file name="10b" lanes="64/byte">
        <load offset="100002" size="20000" />
     </file>
	 <file name="10a" lanes="64/byte">
        <load offset="100003" size="20000" />
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
	</region>
	<region name = "Final Fight 91634B-2 (Japan Hack)" length="200000">
	  <file name="3a" lanes="64/word">
        <load offset="000000" size="80000" />
     </file>
	 <file name="4a" lanes="64/word">
        <load offset="000002" size="80000" />
     </file>
	 <file name="5a" lanes="64/word">
        <load offset="000004" size="80000" />
     </file>
	 <file name="6a" lanes="64/word">
        <load offset="000006" size="80000" />
     </file>
	</region>
	<region name = "Street Fighter II 90629B (World/USA)" length="900000">
	 <file name="4a" lanes="64/word">
	  <load offset="000000" size="80000" />
	 </file>
	 <file name="6a" lanes="64/word">
	  <load offset="000002" size="80000" />
	 </file>
	 <file name="3a" lanes="64/word">
	  <load offset="000004" size="80000" />
	 </file>
	 <file name="5a" lanes="64/word">
	  <load offset="000006" size="80000" />
	 </file>
	 <file name="4c" lanes="64/word">
	  <load offset="200000" size="80000" />
	 </file>
	 <file name="6c" lanes="64/word">
	  <load offset="200002" size="80000" />
	 </file>
	 <file name="3c" lanes="64/word">
	  <load offset="200004" size="80000" />
	 </file>
	 <file name="5c" lanes="64/word">
	  <load offset="200006" size="80000" />
	 </file>
	 <file name="4d" lanes="64/word">
	  <load offset="400000" size="80000" />
	 </file>
	 <file name="6d" lanes="64/word">
	  <load offset="400002" size="80000" />
	 </file>
	 <file name="3d" lanes="64/word">
	  <load offset="400004" size="80000" />
	 </file>
	 <file name="5d" lanes="64/word">
	  <load offset="400006" size="80000" />
	 </file>
	</region>
	<region name = "Street Fighter II 90629B (Japan)" length="900000">
	 <file name="8a" lanes="64/word">
	  <load offset="000000" size="80000" />
	 </file>
	 <file name="10a" lanes="64/word">
	  <load offset="000002" size="80000" />
	 </file>
	 <file name="7a" lanes="64/word">
	  <load offset="000004" size="80000" />
	 </file>
	 <file name="9a" lanes="64/word">
	  <load offset="000006" size="80000" />
	 </file>
	 <file name="8c" lanes="64/word">
	  <load offset="200000" size="80000" />
	 </file>
	 <file name="10c" lanes="64/word">
	  <load offset="200002" size="80000" />
	 </file>
	 <file name="7c" lanes="64/word">
	  <load offset="200004" size="80000" />
	 </file>
	 <file name="9c" lanes="64/word">
	  <load offset="200006" size="80000" />
	 </file>
	 <file name="8d" lanes="64/word">
	  <load offset="400000" size="80000" />
	 </file>
	 <file name="10d" lanes="64/word">
	  <load offset="400002" size="80000" />
	 </file>
	 <file name="7d" lanes="64/word">
	  <load offset="400004" size="80000" />
	 </file>
	 <file name="9d" lanes="64/word">
	  <load offset="400006" size="80000" />
	 </file>
	</region>
	<region name = "Knights of the Round 91635B-2 (World, USA)" length="400000">
	 <file name="3a" lanes="64/word">
	  <load offset="000000" size="80000" />
	 </file>
	 <file name="5a" lanes="64/word">
	  <load offset="000002" size="80000" />
	 </file>
	 <file name="4a" lanes="64/word">
	  <load offset="000004" size="80000" />
	 </file>
	 <file name="6a" lanes="64/word">
	  <load offset="000006" size="80000" />
	 </file>
	 <file name="7a" lanes="64/word">
	  <load offset="200000" size="80000" />
	 </file>
	 <file name="9a" lanes="64/word">
	  <load offset="200002" size="80000" />
	 </file>
	 <file name="8a" lanes="64/word">
	  <load offset="200004" size="80000" />
	 </file>
	 <file name="10a" lanes="64/word">
	  <load offset="200006" size="80000" />
	 </file>
	</region>
	<region name = "Knights of the Round 91634-2 (Japan)" length="400000">
	 <file name="3a" lanes="64/word">
	  <load offset="000000" size="80000" />
	 </file>
	 <file name="4a" lanes="64/word">
	  <load offset="000002" size="80000" />
	 </file>
	 <file name="5a" lanes="64/word">
	  <load offset="000004" size="80000" />
	 </file>
	 <file name="6a" lanes="64/word">
	  <load offset="000006" size="80000" />
	 </file>
	 <file name="7a" lanes="64/word">
	  <load offset="200000" size="80000" />
	 </file>
	 <file name="8a" lanes="64/word">
	  <load offset="200002" size="80000" />
	 </file>
	 <file name="9a" lanes="64/word">
	  <load offset="200004" size="80000" />
	 </file>
	 <file name="10a" lanes="64/word">
	  <load offset="200006" size="80000" />
	 </file>
	</region>
	<region name = "Knights of the Round 89625B-1 (Japan)" length="400000">
	 <file name="4b" lanes="64/byte">
	  <load offset="000000" size="20000" />
	 </file>
	 <file name="4a" lanes="64/byte">
	  <load offset="000001" size="20000" />
	 </file>
	 <file name="9b" lanes="64/byte">
	  <load offset="000002" size="20000" />
	 </file>
	 <file name="9a" lanes="64/byte">
	  <load offset="000003" size="20000" />
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
	 <file name="5b" lanes="64/byte">
	  <load offset="100000" size="20000" />
	 </file>
	 <file name="5a" lanes="64/byte">
	  <load offset="100001" size="20000" />
	 </file>
	 <file name="10b" lanes="64/byte">
	  <load offset="100002" size="20000" />
	 </file>
	 <file name="10a" lanes="64/byte">
	  <load offset="100003" size="20000" />
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
	 <file name="7b" lanes="64/byte">
	  <load offset="200000" size="20000" />
	 </file>
	 <file name="7a" lanes="64/byte">
	  <load offset="200001" size="20000" />
	 </file>
	 <file name="11b" lanes="64/byte">
	  <load offset="200002" size="20000" />
	 </file>
	 <file name="11a" lanes="64/byte">
	  <load offset="200003" size="20000" />
	 </file>
	 <file name="8e" lanes="64/byte">
	  <load offset="200004" size="20000" />
	 </file>
	 <file name="8c" lanes="64/byte">
	  <load offset="200005" size="20000" />
	 </file>
	 <file name="10e" lanes="64/byte">
	  <load offset="200006" size="20000" />
	 </file>
	 <file name="10c" lanes="64/byte">
	  <load offset="200007" size="20000" />
	 </file>
	 <file name="8b" lanes="64/byte">
	  <load offset="300000" size="20000" />
	 </file>
	 <file name="8a" lanes="64/byte">
	  <load offset="300001" size="20000" />
	 </file>
	 <file name="12b" lanes="64/byte">
	  <load offset="300002" size="20000" />
	 </file>
	 <file name="12a" lanes="64/byte">
	  <load offset="300003" size="20000" />
	 </file>
	 <file name="9e" lanes="64/byte">
	  <load offset="300004" size="20000" />
	 </file>
	 <file name="9c" lanes="64/byte">
	  <load offset="300005" size="20000" />
	 </file>
	 <file name="11e" lanes="64/byte">
	  <load offset="300006" size="20000" />
	 </file>
	 <file name="11c" lanes="64/byte">
	  <load offset="300007" size="20000" />
	 </file>
	</region>
	<region name = "Street Fighter II Champion Edition 91635B-2 (World/USA)" length="900000">
	 <file name="3a" lanes="64/word">
	  <load offset="000000" size="80000" />
	 </file>
	 <file name="5a" lanes="64/word">
	  <load offset="000002" size="80000" />
	 </file>
	 <file name="4a" lanes="64/word">
	  <load offset="000004" size="80000" />
	 </file>
	 <file name="6a" lanes="64/word">
	  <load offset="000006" size="80000" />
	 </file>
	 <file name="7a" lanes="64/word">
	  <load offset="200000" size="80000" />
	 </file>
	 <file name="9a" lanes="64/word">
	  <load offset="200002" size="80000" />
	 </file>
	 <file name="8a" lanes="64/word">
	  <load offset="200004" size="80000" />
	 </file>
	 <file name="10a" lanes="64/word">
	  <load offset="200006" size="80000" />
	 </file>
	 <file name="3c" lanes="64/word">
	  <load offset="400000" size="80000" />
	 </file>
	 <file name="5c" lanes="64/word">
	  <load offset="400002" size="80000" />
	 </file>
	 <file name="4c" lanes="64/word">
	  <load offset="400004" size="80000" />
	 </file>
	 <file name="6c" lanes="64/word">
	  <load offset="400006" size="80000" />
	 </file>
	</region>
	<region name = "Street Fighter II Champion Edition 91634B-2 (Japan)" length="900000">
	 <file name="3a" lanes="64/word">
	  <load offset="000000" size="80000" />
	 </file>
	 <file name="4a" lanes="64/word">
	  <load offset="000002" size="80000" />
	 </file>
	 <file name="5a" lanes="64/word">
	  <load offset="000004" size="80000" />
	 </file>
	 <file name="6a" lanes="64/word">
	  <load offset="000006" size="80000" />
	 </file>
	 <file name="7a" lanes="64/word">
	  <load offset="200000" size="80000" />
	 </file>
	 <file name="8a" lanes="64/word">
	  <load offset="200002" size="80000" />
	 </file>
	 <file name="9a" lanes="64/word">
	  <load offset="200004" size="80000" />
	 </file>
	 <file name="10a" lanes="64/word">
	  <load offset="200006" size="80000" />
	 </file>
	 <file name="3c" lanes="64/word">
	  <load offset="400000" size="80000" />
	 </file>
	 <file name="4c" lanes="64/word">
	  <load offset="400002" size="80000" />
	 </file>
	 <file name="5c" lanes="64/word">
	  <load offset="400004" size="80000" />
	 </file>
	 <file name="6c" lanes="64/word">
	  <load offset="400006" size="80000" />
	 </file>
	</region>
	<region name = "Street Fighter II Champion Edition (Rainbow & Derivative Hacks)" length="900000">
	 <file name="s92_01" lanes="64/word">
	  <load offset="000000" size="80000" />
	 </file>
	 <file name="s92_02" lanes="64/word">
	  <load offset="000002" size="80000" />
	 </file>
	 <file name="s92_03" lanes="64/word">
	  <load offset="000004" size="80000" />
	 </file>
	 <file name="s92_04" lanes="64/word">
	  <load offset="000006" size="80000" />
	 </file>
	 <file name="s92_05" lanes="64/word">
	  <load offset="200000" size="80000" />
	 </file>
	 <file name="s92_06" lanes="64/word">
	  <load offset="200002" size="80000" />
	 </file>
	 <file name="s92_07" lanes="64/word">
	  <load offset="200004" size="80000" />
	 </file>
	 <file name="s92_08" lanes="64/word">
	  <load offset="200006" size="80000" />
	 </file>
	 <file name="s92_10" lanes="64/word">
	  <load offset="400000" size="80000" />
	 </file>
	 <file name="s92_11" lanes="64/word">
	  <load offset="400002" size="80000" />
	 </file>
	 <file name="s92_12" lanes="64/word">
	  <load offset="400004" size="80000" />
	 </file>
	 <file name="s92_13" lanes="64/word">
	  <load offset="400006" size="80000" />
	 </file>
	</region>
  </regions>
</profile:profile>
