<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Battlantis"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Characters">
			<plane>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
			</plane>
			<x multiplier="4">
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="6" />
				<offset bits="7" />
				<offset bits="4" />
				<offset bits="5" />
			</x>
			<y multiplier="32">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
			</y>
			<stride>256</stride>
		</layout>
		<layout name="Sprites">
			<plane>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
			</plane>
			<x multiplier="4">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
			</x>
			<y multiplier="32">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
			</y>
			<stride>256</stride>
		</layout>
	</layouts>

	<regions>
		<region name="Battlantis (Characters)" length="40000">
			<file name="13a">
				<load offset="00000" size="40000" />
			</file>
		</region>
		<region name="Battlantis (Sprites)" length="40000">
			<file name="13e">
				<load offset="00000" size="40000" />
			</file>
		</region>

		<region name="The Hustler (Characters)" length="40000">
			<file name="13a">
				<load offset="00000" size="40000" />
			</file>
		</region>
		<region name="The Hustler (Sprites)" length="40000">
			<file name="13e">
				<load offset="00000" size="40000" />
			</file>
		</region>
	</regions>
</profile:profile>