<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Street Fighter"
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

		<layout name="Sprites">
			<plane>
				<offset bits="4" />
				<offset bits="0" />
				<offset bits="4" fracnum="1" fracden="2" />
				<offset bits="0" fracnum="1" fracden="2" />
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
		<region name="Sprites 1" length="80000">
			<file name="sf-39">
				<load offset="00000" size="20000" />
			</file>
			<file name="sf-38">
				<load offset="20000" size="20000" />
			</file>
			<file name="sf-41">
				<load offset="40000" size="20000" />
			</file>
			<file name="sf-40">
				<load offset="60000" size="20000" />
			</file>
		</region>

		<region name="Sprites 2" length="100000">
			<file name="sf-25">
				<load offset="000000" size="20000" />
			</file>
			<file name="sf-28">
				<load offset="020000" size="20000" />
			</file>
			<file name="sf-30">
				<load offset="040000" size="20000" />
			</file>
			<file name="sf-34">
				<load offset="060000" size="20000" />
			</file>
			<file name="sf-26">
				<load offset="080000" size="20000" />
			</file>
			<file name="sf-29">
				<load offset="0A0000" size="20000" />
			</file>
			<file name="sf-31">
				<load offset="0C0000" size="20000" />
			</file>
			<file name="sf-35">
				<load offset="0E0000" size="20000" />
			</file>
		</region>

		<region name="Sprites 3" length="1C0000">
			<!-- sprite planes 1-2 -->
			<file name="sf-15">
				<load offset="000000" size="20000" />
			</file>
			<file name="sf-16">
				<load offset="020000" size="20000" />
			</file>
			<file name="sf-11">
				<load offset="040000" size="20000" />
			</file>
			<file name="sf-12">
				<load offset="060000" size="20000" />
			</file>
			<file name="sf-07">
				<load offset="080000" size="20000" />
			</file>
			<file name="sf-08">
				<load offset="0A0000" size="20000" />
			</file>
			<file name="sf-03">
				<load offset="0C0000" size="20000" />
			</file>
			<!-- sprite planes 2-3 -->
			<file name="sf-17">
				<load offset="0E0000" size="20000" />
			</file>
			<file name="sf-18">
				<load offset="100000" size="20000" />
			</file>
			<file name="sf-13">
				<load offset="120000" size="20000" />
			</file>
			<file name="sf-14">
				<load offset="140000" size="20000" />
			</file>
			<file name="sf-09">
				<load offset="160000" size="20000" />
			</file>
			<file name="sf-10">
				<load offset="180000" size="20000" />
			</file>
			<file name="sf-05">
				<load offset="1A0000" size="20000" />
			</file>
		</region>

		<region name="Characters" length="4000">
			<file name="sf-27">
				<load offset="0000" size="4000" />
			</file>
		</region>
	</regions>
</profile:profile>