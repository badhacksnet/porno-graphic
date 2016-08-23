<?xml version="1.0" encoding="utf-8"?>
<profile:profile name="Konami DJMAIN Hardware"
    xsi:schemaLocation="http://baddesthacks.net/porno-graphic/profile profile.xsd"
    xmlns:profile="http://baddesthacks.net/porno-graphic/profile"
    xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
>
	<layouts>
		<layout name="Sprites">
			<plane multiplier="1">
				<offset bits="0" />
				<offset bits="1" />
				<offset bits="2" />
				<offset bits="3" />
			</plane>
			<x multiplier="1">
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
			<y multiplier="1">
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
		<region name="Sprites" length="200000">
			<file name="19a" lanes="16/byte">
				<load offset="000000" size="80000" />
			</file>
			<file name="20a" lanes="16/byte">
				<load offset="000001" size="80000" />
			</file>
			<file name="22a" lanes="16/byte">
				<load offset="100000" size="80000" />
			</file>
			<file name="24a" lanes="16/byte">
				<load offset="100001" size="80000" />
			</file>
		</region>
	</regions>
</profile:profile>