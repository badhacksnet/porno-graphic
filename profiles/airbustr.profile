<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Air Buster"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Tiles">
			<plane>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
			</plane>
			<x>
				<offset bits="4" />
				<offset bits="0" />
				<offset bits="12" />
				<offset bits="8" />
				<offset bits="20" />
				<offset bits="16" />
				<offset bits="28" />
				<offset bits="24" />
				<offset bits="260" />
				<offset bits="256" />
				<offset bits="268" />
				<offset bits="264" />
				<offset bits="276" />
				<offset bits="272" />
				<offset bits="284" />
				<offset bits="280" />
			</x>
			<y>
				<offset bits="0" />
				<offset bits="32" />
				<offset bits="64" />
				<offset bits="96" />
				<offset bits="128" />
				<offset bits="160" />
				<offset bits="192" />
				<offset bits="224" />
				<offset bits="512" />
				<offset bits="544" />
				<offset bits="576" />
				<offset bits="608" />
				<offset bits="640" />
				<offset bits="672" />
				<offset bits="704" />
				<offset bits="736" />
			</y>
			<stride>1024</stride>
		</layout>

		<layout name="Sprites">
			<plane>
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
			</plane>
			<x>
				<offset bits="0" />
				<offset bits="4" />
				<offset bits="8" />
				<offset bits="12" />
				<offset bits="16" />
				<offset bits="20" />
				<offset bits="24" />
				<offset bits="28" />
				<offset bits="256" />
				<offset bits="260" />
				<offset bits="264" />
				<offset bits="268" />
				<offset bits="272" />
				<offset bits="276" />
				<offset bits="280" />
				<offset bits="284" />
			</x>
			<y>
				<offset bits="0" />
				<offset bits="32" />
				<offset bits="64" />
				<offset bits="96" />
				<offset bits="128" />
				<offset bits="160" />
				<offset bits="192" />
				<offset bits="224" />
				<offset bits="512" />
				<offset bits="544" />
				<offset bits="576" />
				<offset bits="608" />
				<offset bits="640" />
				<offset bits="672" />
				<offset bits="704" />
				<offset bits="736" />
			</y>
			<stride>1024</stride>
		</layout>
	</layouts>

	<regions>
		<region name="Tiles" length="80000">
			<file name="pr-000">
				<load offset="00000" size="80000" />
			</file>
		</region>
		<region name="Sprites" length="100000">
			<file name="pr-001">
				<load offset="00000" size="80000" />
			</file>
			<file name="pr-02">
				<load offset="80000" size="10000" />
			</file>
		</region>
	</regions>
</profile:profile>