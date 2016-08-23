<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Bomb Jack"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Characters">
			<plane multiplier="1">
				<offset fracnum="0" fracden="3" />
				<offset fracnum="1" fracden="3" />
				<offset fracnum="2" fracden="3" />
			</plane>
			<x>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
			</x>
			<y multiplier="8">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
			</y>
			<stride>64</stride>
		</layout>

		<layout name="Tiles">
			<plane multiplier="1">
				<offset fracnum="0" fracden="3" />
				<offset fracnum="1" fracden="3" />
				<offset fracnum="2" fracden="3" />
			</plane>
			<x>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
				<offset bits="64" />
				<offset bits="65" />
				<offset bits="66" />
				<offset bits="67" />
				<offset bits="68" />
				<offset bits="69" />
				<offset bits="70" />
				<offset bits="71" />
			</x>
			<y multiplier="8">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
				<offset bits="16" />
				<offset bits="17" />
				<offset bits="18" />
				<offset bits="19" />
				<offset bits="20" />
				<offset bits="21" />
				<offset bits="22" />
				<offset bits="23" />
			</y>
			<stride>256</stride>
		</layout>

		<layout name="Sprites">
			<plane multiplier="65536">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
			</plane>
			<x>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
				<offset bits="64" />
				<offset bits="65" />
				<offset bits="66" />
				<offset bits="67" />
				<offset bits="68" />
				<offset bits="69" />
				<offset bits="70" />
				<offset bits="71" />
			</x>
			<y multiplier="8">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
				<offset bits="16" />
				<offset bits="17" />
				<offset bits="18" />
				<offset bits="19" />
				<offset bits="20" />
				<offset bits="21" />
				<offset bits="22" />
				<offset bits="23" />
			</y>
			<stride>256</stride>
		</layout>

		<layout name="Large Sprites">
			<plane multiplier="65536">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
			</plane>
			<x>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
				<offset bits="64" />
				<offset bits="65" />
				<offset bits="66" />
				<offset bits="67" />
				<offset bits="68" />
				<offset bits="69" />
				<offset bits="70" />
				<offset bits="71" />
				<offset bits="256" />
				<offset bits="257" />
				<offset bits="258" />
				<offset bits="259" />
				<offset bits="260" />
				<offset bits="261" />
				<offset bits="262" />
				<offset bits="263" />
				<offset bits="320" />
				<offset bits="321" />
				<offset bits="322" />
				<offset bits="323" />
				<offset bits="324" />
				<offset bits="325" />
				<offset bits="326" />
				<offset bits="327" />
			</x>
			<y multiplier="8">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
				<offset bits="16" />
				<offset bits="17" />
				<offset bits="18" />
				<offset bits="19" />
				<offset bits="20" />
				<offset bits="21" />
				<offset bits="22" />
				<offset bits="23" />
				<offset bits="64" />
				<offset bits="65" />
				<offset bits="66" />
				<offset bits="67" />
				<offset bits="68" />
				<offset bits="69" />
				<offset bits="70" />
				<offset bits="71" />
				<offset bits="80" />
				<offset bits="81" />
				<offset bits="82" />
				<offset bits="83" />
				<offset bits="84" />
				<offset bits="85" />
				<offset bits="86" />
				<offset bits="87" />
			</y>
			<stride>1024</stride>
		</layout>
	</layouts>

	<regions>
		<region name="Characters" length="3000">
			<file name="03_e08t">
				<load offset="0000" size="0000" />
			</file>
			<file name="04_h08t">
				<load offset="1000" size="1000" />
			</file>
			<file name="05_k08t">
				<load offset="2000" size="1000" />
			</file>
		</region>
		<region name="Tiles" length="6000">
			<file name="06_l08t">
				<load offset="0000" size="2000" />
			</file>
			<file name="07_n08t">
				<load offset="2000" size="2000" />
			</file>
			<file name="08_r08t">
				<load offset="4000" size="2000" />
			</file>
		</region>
		<region name="Sprites" length="6000">
			<file name="16_m07b">
				<load offset="0000" size="2000" />
			</file>
			<file name="15_l07b">
				<load offset="2000" size="2000" />
			</file>
			<file name="14_j07b">
				<load offset="4000" size="2000" />
			</file>
		</region>
	</regions>
</profile:profile>