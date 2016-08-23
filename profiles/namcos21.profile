<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Namco System 21"
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
				<offset bits="4" />
				<offset bits="5" />
				<offset bits="6" />
				<offset bits="7" />
			</plane>
			<x multiplier="8">
				<offset bits="0" />
				<offset bits="0" fracnum="1" fracden="4" />
				<offset bits="0" fracnum="2" fracden="4" />
				<offset bits="0" fracnum="3" fracden="4" />
				<offset bits="1" />
				<offset bits="1" fracnum="1" fracden="4" />
				<offset bits="1" fracnum="2" fracden="4" />
				<offset bits="1" fracnum="3" fracden="4" />
				<offset bits="2" />
				<offset bits="2" fracnum="1" fracden="4" />
				<offset bits="2" fracnum="2" fracden="4" />
				<offset bits="2" fracnum="3" fracden="4" />
				<offset bits="3" />
				<offset bits="3" fracnum="1" fracden="4" />
				<offset bits="3" fracnum="2" fracden="4" />
				<offset bits="3" fracnum="3" fracden="4" />
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
		<region name="Air Combat" length="400000">
			<file name="5s">
				<load offset="000000" size="80000" />
			</file>
			<file name="4s">
				<load offset="080000" size="80000" />
			</file>
			<file name="5x">
				<load offset="100000" size="80000" />
			</file>
			<file name="4x">
				<load offset="180000" size="80000" />
			</file>
			<file name="3s">
				<load offset="200000" size="80000" />
			</file>
			<file name="2s">
				<load offset="280000" size="80000" />
			</file>
			<file name="3x">
				<load offset="300000" size="80000" />
			</file>
			<file name="2x">
				<load offset="380000" size="80000" />
			</file>
		</region>

		<region name="Cyber Sled" length="400000">
			<file name="5s">
				<load offset="000000" size="80000" />
			</file>
			<file name="4s">
				<load offset="080000" size="80000" />
			</file>
			<file name="5x">
				<load offset="100000" size="80000" />
			</file>
			<file name="4x">
				<load offset="180000" size="80000" />
			</file>
			<file name="3s">
				<load offset="200000" size="80000" />
			</file>
			<file name="2s">
				<load offset="280000" size="80000" />
			</file>
			<file name="3x">
				<load offset="300000" size="80000" />
			</file>
			<file name="2x">
				<load offset="380000" size="80000" />
			</file>
		</region>

		<region name="Driver's Eyes" length="200000">
			<file name="5s">
				<load offset="000000" size="40000" />
			</file>
			<file name="4s">
				<load offset="040000" size="40000" />
			</file>
			<file name="5x">
				<load offset="080000" size="40000" />
			</file>
			<file name="4x">
				<load offset="0C0000" size="40000" />
			</file>
			<file name="3s">
				<load offset="100000" size="40000" />
			</file>
			<file name="2s">
				<load offset="140000" size="40000" />
			</file>
			<file name="3x">
				<load offset="180000" size="40000" />
			</file>
			<file name="2x">
				<load offset="1C0000" size="40000" />
			</file>
		</region>

		<region name="Starblade" length="200000">
			<file name="st-obj0">
				<load offset="000000" size="80000" />
			</file>
			<file name="st-obj1">
				<load offset="080000" size="80000" />
			</file>
			<file name="st-obj2">
				<load offset="100000" size="80000" />
			</file>
			<file name="st-obj3">
				<load offset="180000" size="80000" />
			</file>
		</region>

		<region name="Solvalou" length="400000">
			<file name="obj0">
				<load offset="000000" size="80000" />
			</file>
			<file name="obj4">
				<load offset="080000" size="80000" />
			</file>
			<file name="obj1">
				<load offset="100000" size="80000" />
			</file>
			<file name="obj5">
				<load offset="180000" size="80000" />
			</file>
			<file name="obj2">
				<load offset="200000" size="80000" />
			</file>
			<file name="obj6">
				<load offset="280000" size="80000" />
			</file>
			<file name="obj3">
				<load offset="300000" size="80000" />
			</file>
			<file name="obj7">
				<load offset="380000" size="80000" />
			</file>
		</region>
	</regions>
</profile:profile>