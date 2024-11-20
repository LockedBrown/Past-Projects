import discord
from discord.ext import commands
import random

client = commands.Bot(command_prefix = '.')

@client.event
async def on_ready():
    await client.change_presence(status=discord.Status.idle, activity=discord.Game('Rhys Mind Game'))
    print('Bot is ready.')

@client.command()
async def ping(ctx):
    await ctx.send(f'Pong! {round(client.latency * 1000)}ms')
    
	
	
@client.command()
async def ding(ctx):
    await ctx.send(f'-play https://www.youtube.com/watch?v=-yIVRRN42oU')
    
@client.command(aliases=['8ball'])
async def _8ball(ctx, *, question):

    responses = ['It is certain.',
                'It is decidedly so.',
                'Without a doubt.',
                'Yes - definitely.',
                'You may rely on it.',
                'As I see it, yes.',
                'Most likely.',
                'Outlook good.',
                'Yes.',
                'Signs point to yes.',
                'Reply hazy, try again.',
                'Ask again later.',
                'Better not tell you now.',
                'Cannot predict now.',
                'Concentrate and ask again.',
                'Dont count on it.',
                'My reply is no.',
                'My sources say no.',
                'Outlook not so good.',
                'Very doubtful.']
    await ctx.send(f'Question: {question}\nAnswer: {random.choice(responses)}')


client.run('') ## NEEDS LOGIN TOKEN

