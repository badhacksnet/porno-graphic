<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Sega System 18"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Characters">
			<plane>
				<offset fracnum="2" fracden="3" />
				<offset fracnum="1" fracden="3" />
				<offset fracnum="0" fracden="3" />
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
	</layouts>

	<regions>
		<region name="Alien Storm (Tiles)" length="C0000">
			<file name="epr-13073">
				<load offset="00000" size="40000" />
			</file>
			<file name="epr-13074">
				<load offset="40000" size="40000" />
			</file>
			<file name="epr-13075">
				<load offset="80000" size="40000" />
			</file>
		</region>

		<region name="Bloxeed (Tiles)" length="30000">
			<file name="b1">
				<load offset="00000" size="10000" />
			</file>
			<file name="b2">
				<load offset="10000" size="10000" />
			</file>
			<file name="b3">
				<load offset="20000" size="10000" />
			</file>
		</region>

		<region name="Clutch Hitter (Tiles)" length="180000">
			<file name="c1">
				<load offset="000000" size="80000" />
			</file>
			<file name="c2">
				<load offset="080000" size="80000" />
			</file>
			<file name="c3">
				<load offset="100000" size="80000" />
			</file>
		</region>

		<region name="D.D. Crew (Tiles)" length="C0000">
			<file name="c1">
				<load offset="00000" size="40000" />
			</file>
			<file name="c2">
				<load offset="40000" size="40000" />
			</file>
			<file name="c3">
				<load offset="80000" size="40000" />
			</file>
		</region>

		<region name="Desert Breaker (Tiles)" length="300000">
			<file name="c1">
				<load offset="000000" size="100000" />
			</file>
			<file name="c2">
				<load offset="100000" size="100000" />
			</file>
			<file name="c3">
				<load offset="200000" size="100000" />
			</file>
		</region>

		<region name="Hammer Away (Tiles)" length="180000">
			<file name="c10">
				<load offset="000000" size="40000" />
			</file>
			<file name="1">
				<load offset="040000" size="40000" />
			</file>
			<file name="c11">
				<load offset="080000" size="40000" />
			</file>
			<file name="2">
				<load offset="0c0000" size="40000" />
			</file>
			<file name="c12">
				<load offset="100000" size="40000" />
			</file>
			<file name="3">
				<load offset="140000" size="40000" />
			</file>
		</region>

		<region name="Laser Ghost (Tiles)" length="C0000">
			<file name="c1">
				<load offset="00000" size="40000" />
			</file>
			<file name="c2">
				<load offset="40000" size="40000" />
			</file>
			<file name="c3">
				<load offset="80000" size="40000" />
			</file>
		</region>

		<region name="Michael Jackson's Moonwalker (Tiles)" length="C0000">
			<file name="b1">
				<load offset="00000" size="40000" />
			</file>
			<file name="b2">
				<load offset="40000" size="40000" />
			</file>
			<file name="b3">
				<load offset="80000" size="40000" />
			</file>
		</region>

		<!-- xxx: tiles appear to be horizontally flipped? rotation: 270 degrees -->
		<region name="Pontoon (Tiles)" length="C0000">
			<file name="b1">
				<load offset="00000" size="40000" />
			</file>
			<file name="b2">
				<load offset="40000" size="40000" />
			</file>
			<file name="b3">
				<load offset="80000" size="40000" />
			</file>
		</region>

		<region name="Shadow Dancer (Tiles)" length="C0000">
			<file name="b1">
				<load offset="00000" size="40000" />
			</file>
			<file name="b2">
				<load offset="40000" size="40000" />
			</file>
			<file name="b3">
				<load offset="80000" size="40000" />
			</file>
		</region>

		<region name="Wally wo Sasage! (Where's Wally?) (Tiles)" length="C0000">
			<file name="c1">
				<load offset="00000" size="40000" />
			</file>
			<file name="c2">
				<load offset="40000" size="40000" />
			</file>
			<file name="c3">
				<load offset="80000" size="40000" />
			</file>
		</region>
	</regions>
</profile:profile>