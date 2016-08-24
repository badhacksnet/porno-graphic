<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Shangai 3"
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
				<offset bits="1" />
				<offset bits="0" />
				<offset bits="3" />
				<offset bits="2" />
				<offset bits="5" />
				<offset bits="4" />
				<offset bits="7" />
				<offset bits="6" />
				<offset bits="9" />
				<offset bits="8" />
				<offset bits="11" />
				<offset bits="10" />
				<offset bits="13" />
				<offset bits="12" />
				<offset bits="15" />
				<offset bits="14" />
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
	</layouts>

	<regions>
		<region name="Shanghai 3 (World)" length="400000">
			<file name="ic43">
				<load offset="000000" size="200000" />
			</file>
			<file name="ic44">
				<load offset="200000" size="080000" />
			</file>
		</region>

		<region name="Shanghai 3 (Japan, USA)" length="200000">
			<file name="ic43">
				<load offset="000000" size="200000" />
			</file>
		</region>

		<region name="Hebereke no Popoon" length="380000" erase="ff">
			<file name="hbpic98">
				<load offset="000000" size="80000" />
			</file>
			<file name="hbpic99">
				<load offset="080000" size="80000" />
			</file>
			<file name="hbpic100">
				<load offset="100000" size="80000" />
			</file>
			<file name="hbpic101">
				<load offset="180000" size="80000" />
			</file>
			<file name="hbpic102">
				<load offset="200000" size="80000" />
			</file>
			<file name="hbpic103">
				<load offset="280000" size="80000" />
			</file>
			<file name="hbpic104">
				<load offset="300000" size="80000" />
			</file>
		</region>

		<region name="Blocken" length="380000" erase="ff">
			<file name="ic98j">
				<load offset="000000" size="80000" />
			</file>
			<file name="ic99j">
				<load offset="080000" size="80000" />
			</file>
			<fill offset="100000" size="100000" value="ff" />
			<file name="ic100j">
				<load offset="200000" size="80000" />
			</file>
			<fill offset="280000" size="100000" value="ff" />
		</region>
	</regions>
</profile:profile>