<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Bagman Hardware"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Characters">
			<plane multiplier="32768">
				<offset bits="0" />
				<offset bits="1" />
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
		<layout name="Sprites">
			<plane multiplier="32768">
				<offset bits="0" />
				<offset bits="1" />
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
	</layouts>

	<regions>
		<region name="Bagman Characters 1" length="2000">
			<file name="e1_b02">
				<load offset="0" size="1000" />
			</file>
			<file name="j1_b04">
				<load offset="1000" size="1000" />
			</file>
		</region>

		<region name="Bagman Sprites" length="2000">
			<file name="e1_b02">
				<load offset="0" size="1000" />
			</file>
			<file name="j1_b04">
				<load offset="1000" size="1000" />
			</file>
		</region>

		<region name="Bagman Characters 2" length="2000">
			<file name="c1_b01">
				<load offset="0" size="1000" />
			</file>
			<file name="f1_b03s">
				<load offset="1000" size="1000" />
			</file>
		</region>

		<region name="Super Bagman Characters 1" length="2000">
			<file name="2.1e">
				<load offset="0" size="1000" />
			</file>
			<file name="4.1j">
				<load offset="1000" size="1000" />
			</file>
		</region>

		<region name="Super Bagman Sprites" length="2000">
			<file name="2.1e">
				<load offset="0" size="1000" />
			</file>
			<file name="4.1j">
				<load offset="1000" size="1000" />
			</file>
		</region>

		<region name="Super Bagman Characters 2" length="2000">
			<file name="1.1c">
				<load offset="0" size="1000" />
			</file>
			<file name="3.1f">
				<load offset="1000" size="1000" />
			</file>
		</region>

		<region name="Pickin Characters" length="2000">
			<file name="1f">
				<load offset="0" size="1000" />
			</file>
			<file name="1j">
				<load offset="1000" size="1000" />
			</file>
		</region>

		<region name="Pickin Sprites" length="2000">
			<file name="1f">
				<load offset="0" size="1000" />
			</file>
			<file name="1j">
				<load offset="1000" size="1000" />
			</file>
		</region>
	</regions>
</profile:profile>