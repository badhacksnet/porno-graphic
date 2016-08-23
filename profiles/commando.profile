<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Commando"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Characters">
			<plane>
				<offset bits="4" />
				<offset bits="0" />
			</plane>
			<x>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="8" />
				<offset bits="9" />
				<offset bits="10" />
				<offset bits="11" />
			</x>
			<y multiplier="16">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
			</y>
			<stride>128</stride>
		</layout>
		<layout name="Tiles">
			<plane>
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
				<offset bits="128" />
				<offset bits="129" />
				<offset bits="130" />
				<offset bits="131" />
				<offset bits="132" />
				<offset bits="133" />
				<offset bits="134" />
				<offset bits="135" />
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
				<offset bits="8" />
				<offset bits="9" />
				<offset bits="10" />
				<offset bits="11" />
				<offset bits="12" />
				<offset bits="13" />
				<offset bits="14" />
				<offset bits="15" />
			</y>
			<stride>256</stride>
		</layout>
		<layout name="Sprites">
			<plane>
				<offset bits="4" fracnum="1" fracden="2" />
				<offset bits="0" fracnum="1" fracden="2" />
				<offset bits="4" />
				<offset bits="0" />
			</plane>
			<x>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="8" />
				<offset bits="9" />
				<offset bits="10" />
				<offset bits="11" />
				<offset bits="256" />
				<offset bits="257" />
				<offset bits="258" />
				<offset bits="259" />
				<offset bits="264" />
				<offset bits="265" />
				<offset bits="266" />
				<offset bits="267" />
			</x>
			<y multiplier="16">
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
			<stride>512</stride>
		</layout>
	</layouts>

	<regions>
		<region name="Characters" length="4000">
			<file name="vt01.5d">
				<load offset="0000" size="4000" />
			</file>
		</region>
		<region name="Tiles" length="18000">
			<file name="vt11.5a">
				<load offset="00000" size="4000" />
			</file>
			<file name="vt12.6a">
				<load offset="04000" size="4000" />
			</file>
			<file name="vt13.7a">
				<load offset="08000" size="4000" />
			</file>
			<file name="vt14.8a">
				<load offset="0C000" size="4000" />
			</file>
			<file name="vt15.9a">
				<load offset="10000" size="4000" />
			</file>
			<file name="vt16.10a">
				<load offset="14000" size="4000" />
			</file>
		</region>
		<region name="Sprites" length="18000">
			<file name="vt05.7e">
				<load offset="00000" size="4000" />
			</file>
			<file name="vt06.8e">
				<load offset="04000" size="4000" />
			</file>
			<file name="vt07.9e">
				<load offset="08000" size="4000" />
			</file>
			<file name="vt08.7h">
				<load offset="0C000" size="4000" />
			</file>
			<file name="vt09.8h">
				<load offset="10000" size="4000" />
			</file>
			<file name="vt10.9h">
				<load offset="14000" size="4000" />
			</file>
		</region>
	</regions>
</profile:profile>