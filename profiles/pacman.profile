<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Pac-Man"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Tiles">
			<plane multiplier="1">
				<offset bits="0" />
				<offset bits="4" />
			</plane>
			<x multiplier="1">
				<offset bits="64" />
				<offset bits="65" />
				<offset bits="66" />
				<offset bits="67" />
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
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
			<stride>128</stride>
		</layout>

		<layout name="Sprites">
			<plane multiplier="1">
				<offset bits="0" />
				<offset bits="4" />
			</plane>
			<x multiplier="1">
				<offset bits="64" />
				<offset bits="65" />
				<offset bits="66" />
				<offset bits="67" />
				<offset bits="128" />
				<offset bits="129" />
				<offset bits="130" />
				<offset bits="131" />
				<offset bits="192" />
				<offset bits="193" />
				<offset bits="194" />
				<offset bits="195" />
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
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
				<offset bits="32" />
				<offset bits="33" />
				<offset bits="34" />
				<offset bits="35" />
				<offset bits="36" />
				<offset bits="37" />
				<offset bits="38" />
				<offset bits="39" />
			</y>
			<stride>512</stride>
		</layout>

		<layout name="Tiles (Crush 4)">
			<plane multiplier="1">
				<offset bits="0" fracnum="1" fracden="2" />
				<offset bits="4" fracnum="0" fracden="2" />
			</plane>
			<x multiplier="1">
				<offset bits="64" />
				<offset bits="65" />
				<offset bits="66" />
				<offset bits="67" />
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
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
			<stride>128</stride>
		</layout>

    <layout name="Sprites (Crush 4)">
      <plane multiplier="1">
        <offset bits="0" fracnum="1" fracden="2"  />
        <offset bits="4" fracnum="0" fracden="2"  />
      </plane>
      <x multiplier="1">
        <offset bits="64" />
        <offset bits="65" />
        <offset bits="66" />
        <offset bits="67" />
        <offset bits="128" />
        <offset bits="129" />
        <offset bits="130" />
        <offset bits="131" />
        <offset bits="192" />
        <offset bits="193" />
        <offset bits="194" />
        <offset bits="195" />
        <offset bits="0" />
        <offset bits="1" />
        <offset bits="2" />
        <offset bits="3" />
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
        <offset bits="32" />
        <offset bits="33" />
        <offset bits="34" />
        <offset bits="35" />
        <offset bits="36" />
        <offset bits="37" />
        <offset bits="38" />
        <offset bits="39" />
      </y>
      <stride>512</stride>
    </layout>
	</layouts>

	<regions>
		<region name="Tiles (Pac-Man)" length="1000">
			<file name="5e">
				<load offset="0" size="1000" />
			</file>
		</region>

		<region name="Sprites (Pac-Man)" length="1000">
			<file name="5f">
				<load offset="0" size="1000" />
			</file>
		</region>

		<region name="Tiles (Crush 4)" length="4000">
			<file name="crtwt.1">
				<load offset="0000" size="800" />
				<load offset="1000" size="800" />
				<load offset="0800" size="800" />
				<load offset="1800" size="800" />
				<load offset="2000" size="800" />
				<load offset="3000" size="800" />
				<load offset="2800" size="800" />
				<load offset="3800" size="800" />
			</file>
		</region>
	</regions>
</profile:profile>